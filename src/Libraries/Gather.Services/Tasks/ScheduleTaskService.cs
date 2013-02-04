using System;
using System.Collections.Generic;
using System.Linq;
using Gather.Core.Data;
using Gather.Core.Domain.Tasks;

namespace Gather.Services.Tasks
{
    /// <summary>
    /// Task service
    /// </summary>
    public class ScheduleTaskService : IScheduleTaskService
    {

        #region Fields

        private readonly IRepository<ScheduleTask> _taskRepository;

        #endregion

        #region Constructor

        public ScheduleTaskService(IRepository<ScheduleTask> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes a task
        /// </summary>
        /// <param name="task">Task</param>
        public virtual void DeleteTask(ScheduleTask task)
        {
            if (task == null)
                throw new ArgumentNullException("task");

            _taskRepository.Delete(task);
        }

        /// <summary>
        /// Gets a task
        /// </summary>
        /// <param name="taskId">Task identifier</param>
        /// <returns>Task</returns>
        public virtual ScheduleTask GetTaskById(int taskId)
        {
            return taskId == 0 ? null : _taskRepository.GetById(taskId);
        }

        /// <summary>
        /// Gets a task by its type
        /// </summary>
        /// <param name="type">Task type</param>
        /// <returns>Task</returns>
        public virtual ScheduleTask GetTaskByType(string type)
        {
            if (String.IsNullOrWhiteSpace(type))
                return null;

            var query = _taskRepository.Table;
            query = query.Where(st => st.Type == type);
            query = query.OrderByDescending(t => t.Id);

            var task = query.FirstOrDefault();
            return task;
        }

        /// <summary>
        /// Gets all tasks
        /// </summary>
        /// <returns>Tasks</returns>
        public virtual IList<ScheduleTask> GetAllTasks()
        {
            try
            {
                var query = _taskRepository.Table;
                query = query.OrderByDescending(t => t.Seconds);

                var tasks = query.ToList();
                return tasks;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Inserts a task
        /// </summary>
        /// <param name="task">Task</param>
        public virtual void InsertTask(ScheduleTask task)
        {
            if (task == null)
                throw new ArgumentNullException("task");

            _taskRepository.Insert(task);
        }

        /// <summary>
        /// Updates the task
        /// </summary>
        /// <param name="task">Task</param>
        public virtual void UpdateTask(ScheduleTask task)
        {
            if (task == null)
                throw new ArgumentNullException("task");

            _taskRepository.Update(task);
        }

        public void InstallScheduleTasks()
        {
            var currentTasks = GetAllTasks();
            if (currentTasks.Count != 0) return;

            var tasks = new List<ScheduleTask>()
                            {
                                new ScheduleTask()
                                    {
                                        Name = "Keep alive",
                                        Seconds = 600,
                                        Type = "Gather.Services.Common.KeepAliveTask, Gather.Services",
                                        Enabled = true,
                                        StopOnError = false,
                                    },
                                new ScheduleTask()
                                    {
                                        Name = "Twitter Monitor",
                                        Seconds = 30,
                                        Type = "Gather.Services.Projects.Tools.TwitterMonitorTask, Gather.Services",
                                        Enabled = true,
                                        StopOnError = false,
                                    },
                                new ScheduleTask()
                                    {
                                        Name = "Send Message",
                                        Seconds = 300,
                                        Type = "Gather.Services.MessageQueues.Tools.MessageQueueTask, Gather.Services",
                                        Enabled = true,
                                        StopOnError = false,
                                    },
                                new ScheduleTask()
                                    {
                                        Name = "Send Tweets",
                                        Seconds = 60,
                                        Type = "Gather.Services.MessageQueues.Tools.TwitterQueueTask, Gather.Services",
                                        Enabled = true,
                                        StopOnError = false,
                                    }
                                    ,
                                new ScheduleTask()
                                    {
                                        Name = "Project Monitor",
                                        Seconds = 60,
                                        Type = "Gather.Services.Projects.Tools.ProjectMonitorTask, Gather.Services",
                                        Enabled = true,
                                        StopOnError = false,
                                    }
                            };

            tasks.ForEach(x => _taskRepository.Insert(x));
        }

        #endregion

    }
}
