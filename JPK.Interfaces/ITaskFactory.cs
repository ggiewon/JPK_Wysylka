using System;
using System.Threading;
using System.Threading.Tasks;

namespace JPK_WysylkaXML.Interfaces
{
    /// <summary>
    /// Interface for factory creating tasks with handling exceptions
    /// </summary>
    public interface ITaskFactory
    {
        /// <summary>
        /// Create new task with possibility to cancel
        /// </summary>
        /// <param name="action"></param>
        /// <param name="taskScheduler"></param>
        /// <param name="completionHandler"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <returns></returns>
        Task StartNew(Action action, TaskScheduler taskScheduler, Action<Task> completionHandler, CancellationTokenSource cancellationTokenSource);

        /// <summary>
        /// Create new task without possibility to cancel
        /// </summary>
        /// <param name="action"></param>
        /// <param name="taskScheduler"></param>
        /// <param name="completionHandler"></param>
        /// <returns></returns>
        Task StartNew(Action action, TaskScheduler taskScheduler, Action<Task> completionHandler);

        /// <summary>
        /// Create new task
        /// </summary>
        /// <param name="action"></param>
        /// <param name="exceptionHandler"></param>
        /// <param name="completionHandler"></param>
        /// <param name="taskScheduler"></param>
        /// <param name="cancellationTokenSource"></param>
        /// <returns></returns>
        Task StartNew(Action action, Action<Task> exceptionHandler, Action<Task> completionHandler, TaskScheduler taskScheduler, CancellationTokenSource cancellationTokenSource);
    }
}