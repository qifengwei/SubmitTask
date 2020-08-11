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
        public Node GetTopIterationNode(String name) => RecentProject.IterationRootNodes[name];
        public Node GetTopIterationNode(int index) => RecentProject.IterationRootNodes[index];
        public Node FindIterationNode(String name)
        {
            foreach (Node node in GetIterationRootNodes())
            {
                if (node.Name == name) return node;
                if (node.HasChildNodes)
                {
                    Node find = FindNode(node, name);
                    if (find != null) return find;
                }
            }
            return null;
        }
        public NodeCollection GetAreaRootNodes() => RecentProject.AreaRootNodes;
        public Node GetTopAreaNode(String name) => RecentProject.AreaRootNodes[name];
        public Node GetTopAreaNode(int index) => RecentProject.AreaRootNodes[index];
        public Node FindAreaNode(String name)
        {
            foreach (Node node in GetAreaRootNodes())
            {
                if (node.Name == name) return node;
                if (node.HasChildNodes)
                {
                    Node find = FindNode(node, name);
                    if (find != null) return find;
                }
            }
            return null;
        }
        public List<String> GetAllChildNodesName(Node node)
        {
            List<String> names = new List<string>();
            AddChildNodesName(node, ref names);
            return names;
        }
        public List<String> GetAllChildNodesName(NodeCollection collection)
        {
            List<String> names = new List<string>();
            foreach (Node node in collection)
            {
                names.Add(node.Name);
                names.AddRange(GetAllChildNodesName(node));
            }
            return names;
        }
        private void AddChildNodesName(Node node, ref List<String> ls)
        {
            if (!node.HasChildNodes)
            {
                ls.Add(node.Name);
                return;
            }
            else
            {
                ls.Add(node.Name);
                foreach (Node child in node) AddChildNodesName(child, ref ls);
            }
        }
        private Node FindNode(Node parent, String name)
        {
            if (parent.Name == name) return parent;
            if (!parent.HasChildNodes) return null;
            else 
            {
                foreach (Node child in parent.ChildNodes)
                {
                    Node find = FindNode(child, name);
                    if (find != null) return find;
                }
                return null;
            }
        }
    }
}
