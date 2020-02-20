
using System;
using System.Collections.Generic;
using DasContract.Abstraction.Interface;
using DasContract.Abstraction.Interface.Processes.Process;
using DasContract.Abstraction.Interface.Processes.Process.Tasks;
using DasContract.Abstraction.Interface.UserInterface;
using DasContract.Abstraction.SimpleContract.UserInterface;

namespace DasContract.Abstraction.SimpleContract.Processes.Process.Tasks
{
    public class SimpleUserTask : SimpleTask, IUserTask
    {
        IUserForm IUserTask.Form => Form;
        public SimpleUserForm Form { get; set; }

        public DateTime DueDate { get; set; }

        IProcessUser IUserTask.Assignee => Assignee;
        public SimpleProcessUser Assignee { get; set; }

        IEnumerable<IProcessUser> IUserTask.CandidateUsers => CandidateUsers;
        public List<SimpleProcessUser> CandidateUsers { get; set; } = new List<SimpleProcessUser>();


        IEnumerable<IProcessRole> IUserTask.CandidateRoles => CandidateRoles;
        public List<SimpleProcessRole> CandidateRoles { get; set; } = new List<SimpleProcessRole>();

        void IDataCopyable<IUserTask>.CopyDataFrom(IUserTask source)
        {
            //Sorry is you got an exception here. The deep copy would take a long time and I am lazy. 
            //You can only update custom data within the same contract type
            //You can update this by simply adding a deep copy methods, if you really need it
            Form.CopyDataFrom(source.Form);
            DueDate = source.DueDate;
            Assignee = (SimpleProcessUser)source.Assignee;
            CandidateUsers = (List<SimpleProcessUser>)source.CandidateUsers;
            CandidateRoles = (List<SimpleProcessRole>)source.CandidateRoles;
        }
    }
}
