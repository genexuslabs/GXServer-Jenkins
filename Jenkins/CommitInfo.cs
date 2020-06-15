using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneXus.Server.ExternalTool;
using System.Text.RegularExpressions;

namespace GeneXus.Server.ExternalTool.Jenkins
{
    public class InfoCommitData : CommitData
    {
        public InfoCommitData(CommitData commit)
            : base(commit.User, commit.CommitDate, commit.KBName, commit.CommitId, commit.Objects, commit.Comment)
        {
         ParseComments();
        }

        public CommitInfo CommitInformation
        {
            get;
            set;
        }

        public class CommitInfo
        {
           
            public string build { get; set; }
            public string GxUser { get; set; }
         
            public CommitInfo(string b)
            : this(b, string.Empty)
            {
            }
            public CommitInfo()
            {
            }
            public CommitInfo(string b, string u)
            {
                build = b;
                GxUser = u;  
            }

        } 
    private void ParseComments()
    {
        try
        {
                CommitInformation = GetCommitInfo();
        }
        catch
        {
            throw new ArgumentException("Error parsing the information to be sent.");
        }

    }

    private CommitInfo GetCommitInfo()
    {
        try
         {

                CommitInfo CommitInformation = new CommitInfo();
                Regex rx = new Regex(@"(?i)(#build:(?<build>[yes|y]))");
                MatchCollection matches = rx.Matches(Comment);
                foreach (Match match in matches)
                {
                    GroupCollection groups = match.Groups;
                    if (groups["build"].Value != string.Empty)
                        CommitInformation.build = groups["build"].Value;
                }

                Regex rxUser = new Regex(@"((?i)(#GXuser:(?<gxuser>[\w]*$)))");
                MatchCollection matchesuser = rxUser.Matches(Comment);
                foreach (Match match in matchesuser)
                {
                    GroupCollection groups = match.Groups;
                    if (groups["gxuser"].Value != string.Empty)
                        CommitInformation.GxUser = groups["gxuser"].Value;
                    
                }
                
              return CommitInformation;
        }
        catch
        {
            throw new ArgumentException("Parsing of the comment has failed.");
        }
    }
}
}
