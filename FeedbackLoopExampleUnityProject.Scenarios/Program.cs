using Live.Core.Scripting.Utilities;
using System;

namespace FeedbackLoopExampleUnityProject.Scenarios
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var scenario = new FeedbackLoopScenario();
            scenario.Initialise(new SizeInt(800, 600));
        }
    }
}