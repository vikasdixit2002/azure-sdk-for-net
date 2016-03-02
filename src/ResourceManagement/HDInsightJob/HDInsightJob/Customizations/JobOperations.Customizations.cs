// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Management.HDInsight.Job.Models;

namespace Microsoft.Azure.Management.HDInsight.Job
{
    /// <summary>
    /// Operations for managing jobs against HDInsight clusters.
    /// </summary>
    internal partial class JobOperations : IServiceOperations<HDInsightJobManagementClient>, IJobOperations
    {
        /// <summary>
        /// Gets the job output content as memory stream.
        /// </summary>
        /// <param name='jobId'>
        /// Required. The id of the job.
        /// </param>
        /// <param name="storageAccess">
        /// Required. The storage account object of type IStorageAccess.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The job output content as memory stream.
        /// </returns>
        public async Task<Stream> GetJobOutputAsync(string jobId, IStorageAccess storageAccess, CancellationToken cancellationToken)
        {
            var blobReferencePath = await GetJobStatusDirectory(jobId, "stdout");
            return storageAccess.GetFileContent(blobReferencePath);
        }

        /// <summary>
        /// Gets the job error output content as memory stream.
        /// </summary>
        /// <param name='jobId'>
        /// Required. The id of the job.
        /// </param>
        /// <param name="storageAccess">
        /// Required. The storage account object of type IStorageAccess.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The job error output content as memory stream when job fails to run successfully.
        /// </returns>
        public async Task<Stream> GetJobErrorLogsAsync(string jobId, IStorageAccess storageAccess, CancellationToken cancellationToken)
        {
            var blobReferencePath = await GetJobStatusDirectory(jobId, "stderr");
            return storageAccess.GetFileContent(blobReferencePath);
        }

        /// <summary>
        /// Gets the url for job output.
        /// </summary>
        /// <param name='jobId'>
        /// Required. The id of the job.
        /// </param>
        /// <param name="storageAccess">
        /// Required. The storage account object of type IStorageAccess.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The url for job output.
        /// </returns>
        public async Task<Uri> GetJobOutputUrlAsync(string jobId, IStorageAccess storageAccess, CancellationToken cancellationToken)
        {
            var blobReferencePath = await GetJobStatusDirectory(jobId, "stdout");
            return storageAccess.GetFileUrl(blobReferencePath);
        }

        /// <summary>
        /// Gets the url for job error output.
        /// </summary>
        /// <param name='jobId'>
        /// Required. The id of the job.
        /// </param>
        /// <param name="storageAccess">
        /// Required. The storage account object of type IStorageAccess.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The url for job error output.
        /// </returns>
        public async Task<Uri> GetJobErrorLogsUrlAsync(string jobId, IStorageAccess storageAccess, CancellationToken cancellationToken)
        {
            var blobReferencePath = await GetJobStatusDirectory(jobId, "stderr");
            return storageAccess.GetFileUrl(blobReferencePath);
        }

        private async Task<string> GetJobStatusDirectory(string jobId, string file)
        {
            var job = await this.GetJobAsync(jobId);
            var statusDir = GetStatusFolder(job);

            if (statusDir == null)
            {
                throw new CloudException(string.Format("Job {0} was not created with a status folder and therefore no logs were saved.", job.JobDetail.Id));
            }

            return string.Format("user/{0}/{1}/{2}", job.JobDetail.User, statusDir, file);
        }

        private static string GetStatusFolder(JobGetResponse job)
        {
            return job.JobDetail.Userargs.Statusdir == null ? null : job.JobDetail.Userargs.Statusdir.ToString();
        }
    }
}
