using Application.Config;
using Common.LoggerManager;
using Devices.Verifone;
using Execution;
using MIFARE_APP.Config;
using System;

namespace MIFARE_APP
{
    class Program
    {
        private static AppConfig configuration;

        static void Main(string[] args)
        {
            RuntimeParams runtimeParams = new RuntimeParams();
            runtimeParams.ParseArguments(args);

            configuration = SetupEnvironment.SetEnvironment(runtimeParams);

            Console.WriteLine($"Runtime parameters: {runtimeParams}");
            Logger.info($"Runtime parameters: {runtimeParams}");

            // ToDo: implementation
            //
            VerifoneDevice verifoneDevice = new VerifoneDevice();

            verifoneDevice.DeviceHealth();

            if (!runtimeParams.InPipeline)
            {
                // open log file in Notepad++
                Processor.OpenNotePadPlus(SetupEnvironment.GetLogFilenamePath());
            }

#if !DEBUG
            if (!runtimeParams.InPipeline)
            {
                // Wait for key press to exit
                SetupEnvironment.WaitForExitKeyPress();
            }
#endif

            Environment.Exit(0);
        }
    }
}
