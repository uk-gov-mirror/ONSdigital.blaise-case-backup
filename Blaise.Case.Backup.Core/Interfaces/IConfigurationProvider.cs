﻿namespace Blaise.Case.Backup.Core.Interfaces
{
    public interface IConfigurationProvider
    {
        string BucketName { get; }

        string VmName { get; }

        string ProjectId { get; }

        string SubscriptionId { get; }

        string DeadletterTopicId { get; }

        string LocalBackupFolder { get; }

        string SettingsFolder { get; }
    }
}