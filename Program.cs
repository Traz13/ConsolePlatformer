using System;

namespace ConsoleGame
{
	class MainClass
	{
		//	Static Function
		//	 This is the main entry point for the application
		public static void Main (string[] args)
		{
			//	Create our main game loop object
			MainLoop GameLoop = new MainLoop();

			//	Constantly update this object to keep the application moving
			while(GameLoop.Update() == true)
			{
				//	Draw to the screen
				GameLoop.RenderScene();
			}

			//	Cleanup and shutdown
			GameLoop.Shutdown();
		}
	}
}
