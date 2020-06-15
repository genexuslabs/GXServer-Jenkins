using System.Collections.Generic;

namespace GeneXus.Server.ExternalTool
{
    public class CommitData

    {
        public string User { get; set; }
        public string CommitDate { get; set; }

        public string KBName { get; set; }

        public string CommitId { get; set; }

        public List<string> Objects { get; set; }

        public string Comment { get; set; }

        public CommitData(string username, string issuecommitTimeStamp, string IssueKB, string IssueCommitNbr , List<string> listObjects, string comment)

        {
            User = username;
            CommitDate = issuecommitTimeStamp;
            KBName = IssueKB;
            CommitId = IssueCommitNbr;
            Objects = listObjects;
            Comment = comment;
        }
    }
}
