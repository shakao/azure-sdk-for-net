// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Filters to list the jobs.
    /// </summary>
    public partial class JobQueryObject
    {
        /// <summary>
        /// Initializes a new instance of the JobQueryObject class.
        /// </summary>
        public JobQueryObject() { }

        /// <summary>
        /// Initializes a new instance of the JobQueryObject class.
        /// </summary>
        /// <param name="status">Status of the job. Possible values include:
        /// 'Invalid', 'InProgress', 'Completed', 'Failed',
        /// 'CompletedWithWarnings', 'Cancelled', 'Cancelling'</param>
        /// <param name="backupManagementType">Type of backup managmenent for
        /// the job. Possible values include: 'Invalid', 'AzureIaasVM',
        /// 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql'</param>
        /// <param name="operation">Type of operation. Possible values
        /// include: 'Invalid', 'ConfigureBackup', 'Backup', 'Restore',
        /// 'DisableBackup', 'DeleteBackupData'</param>
        /// <param name="jobId">JobID represents the job uniquely.</param>
        /// <param name="startTime">Job has started at this time. Value is in
        /// UTC.</param>
        /// <param name="endTime">Job has ended at this time. Value is in
        /// UTC.</param>
        public JobQueryObject(JobStatus? status = default(JobStatus?), BackupManagementType? backupManagementType = default(BackupManagementType?), JobOperationType? operation = default(JobOperationType?), string jobId = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?))
        {
            Status = status;
            BackupManagementType = backupManagementType;
            Operation = operation;
            JobId = jobId;
            StartTime = startTime;
            EndTime = endTime;
        }

        /// <summary>
        /// Gets or sets status of the job. Possible values include:
        /// 'Invalid', 'InProgress', 'Completed', 'Failed',
        /// 'CompletedWithWarnings', 'Cancelled', 'Cancelling'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public JobStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets type of backup managmenent for the job. Possible
        /// values include: 'Invalid', 'AzureIaasVM', 'MAB', 'DPM',
        /// 'AzureBackupServer', 'AzureSql'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "backupManagementType")]
        public BackupManagementType? BackupManagementType { get; set; }

        /// <summary>
        /// Gets or sets type of operation. Possible values include:
        /// 'Invalid', 'ConfigureBackup', 'Backup', 'Restore',
        /// 'DisableBackup', 'DeleteBackupData'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "operation")]
        public JobOperationType? Operation { get; set; }

        /// <summary>
        /// Gets or sets jobID represents the job uniquely.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or sets job has started at this time. Value is in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets job has ended at this time. Value is in UTC.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

    }
}