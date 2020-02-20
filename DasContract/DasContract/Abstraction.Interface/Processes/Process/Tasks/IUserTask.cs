
using System;
using System.Collections.Generic;
using DasContract.Abstraction.Interface.UserInterface;

namespace DasContract.Abstraction.Interface.Processes.Process.Tasks
{
    public interface IUserTask : ITask, IDataCopyable<IUserTask>
    {
        public IUserForm Form { get; }

        /// <summary>
        /// A due date to fill this form
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// A user who is assigned to perform a task. May be null. 
        /// </summary>
        public IProcessUser Assignee { get; }

        /// <summary>
        /// Process users which are selected to perform this task. 
        /// </summary>
        public IEnumerable<IProcessUser> CandidateUsers { get; }
        /// <summary>
        /// Process roles allowed to execute this task. 
        /// </summary>
        public IEnumerable<IProcessRole> CandidateRoles { get; }
    }
}
