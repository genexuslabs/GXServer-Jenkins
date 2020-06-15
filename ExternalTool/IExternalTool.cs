using System.Collections.Generic;
namespace GeneXus.Server.ExternalTool
{
    public interface IExternalTool
    {
        List<Result> CommitEvent(CommitData issue);
    }
}
