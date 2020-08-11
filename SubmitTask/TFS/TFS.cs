using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace SubmitTask.TFS
{

    public class TFS
    {
        public TfsTeamProjectCollection TFSTeamProject { get; set; }
        public WorkItemStore ItemStore { get; set; }
        public Project RecentProject { get; set; }
        public WorkItemType ItemType { get; set; }
        public WorkItem WorkItem { get; set; }

        public TFS() 
        {
            _ = ConnectTFS();
        }
        public TFS(String username, String password)
        {
            _ = ConnectTFS(username, password);
        }
        public Boolean ConnectTFS()
        {
            try
            {
                TFSTeamProject = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(new Uri(@"http://tfs:8080/tfs/defaultcollection"));
                ItemStore = TFSTeamProject.GetService<WorkItemStore>();
                RecentProject = ItemStore.Projects["TASK"];
                ItemType = RecentProject.WorkItemTypes["TASK"];
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean ConnectTFS(String username, String password, String domain)
        {
            try
            {
                NetworkCredential cred = new NetworkCredential(username, password, domain);
                TFSTeamProject = new TfsTeamProjectCollection(new Uri(@"http://tfs:8080/tfs/defaultcollection"), cred);
                TFSTeamProject.Authenticate();
                ItemStore = TFSTeamProject.GetService<WorkItemStore>();
                RecentProject = ItemStore.Projects["TASK"];
                ItemType = RecentProject.WorkItemTypes["TASK"];
                return true;
            }
            catch
            {
                return false;
            }           
        }
        public Boolean ConnectTFS(String userNameWithDomain, String password)
        {
            try
            {
                String[] nameAndDomain = userNameWithDomain.Split('@');
                String username = nameAndDomain[0];
                String domain = nameAndDomain[1];
                return ConnectTFS(username, password, domain);
            }
            catch (IndexOutOfRangeException e)
            {
                return false;
            }          
        }
        public Boolean ChangeWorkItemStore(String name)
        {
            try
            {
                RecentProject = null;
                RecentProject = ItemStore.Projects["TASK"];
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean ChangeWorkItemType(String name)
        {
            try
            {
                ItemType = RecentProject.WorkItemTypes[name];
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public WorkItemType GetWorkItemType(String name)
        {
            try
            {
                return RecentProject.WorkItemTypes[name];
            }
            catch
            {
                return RecentProject.WorkItemTypes[0];
            }
        }
        public NodeCollection GetIterationRootNodes() => RecentProject.IterationRootNodes;
        public Node GetTopNode(String name) => RecentProject.IterationRootNodes[name];
        public Node GetTopNode(int index) => RecentProject.IterationRootNodes[index];
        public Node FindIterationNode(String Name)
        {
            foreach (Node node in GetIterationRootNodes())
            {
                
            }
            return GetIterationRootNodes()[1];
        }
        
    }
}
