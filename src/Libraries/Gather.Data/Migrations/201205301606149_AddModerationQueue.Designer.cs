// <auto-generated />
namespace Gather.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    
    public sealed partial class AddModerationQueue : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201205301606149_AddModerationQueue"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
