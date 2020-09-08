// Making a menu real quick, it's gonna be a bad one just ignore that 
string option = Console.ReadLine();
if (option == '1')
{
                                string app = ""; // Application download link
                                string app1 = ""; // Application download link
                                string path1 = "c:\\Windows\\MecCache";
                                string path = "c:\\Windows\\MecCache\\temp";
                                string appdir = "c:\\Windows\\MecCache\\temp\\Mapblnk.exe"; // PUT YOUR APP NAME AFTER THE '\\' AFTER THE TEMP AND MAKE SURE IT HAS .exe
                                string appdir1 = "c:\\Windows\\MecCache\\temp\\Inject.bat";

                                if (Directory.Exists(path))
                                {
                                    Console.WriteLine("Please wait . . .");
                                    using (WebClient webClient = new WebClient())
                                    {
                                        webClient.DownloadFile(app, path); // DOWNLOADING THE APPLICATION FROM THE CDN
                                    }

                                    using (WebClient webClient = new WebClient())
                                    {
                                        webClient.DownloadFile(app1, path); // DOWNLOADING THE APPLICATION FROM THE CDN
                                    }


                                    if (Directory.Exists(appdir))
                                    {
                                        Process.Start(appdir); // Launching the application
                                        Process.Start(appdir1);
                                        //MessageBox.Show("Injeced!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Something went wrong!"); // If the application doesn't exist, Usually this shouldn't happen.
                                    }

                                }
                                else
                                {
                                    Directory.CreateDirectory(path1); // CREATING THE PATH
                                    if (Directory.Exists(path1)) // MAKING SURE THAT PATH1 IS CREAED
                                    {
                                        if (Directory.Exists(path)) // CHECKING IF THE PATH IS COMPLETED
                                        {
                                            // DO NOT MAKE ANY CHANGES HERE
                                        }
                                        else
                                        {
                                            Directory.CreateDirectory(path1); // IF IT DOESN'T EXIST IT CREATES IT
                                        }
                                    }
                                }
}    
else
{
Console.Clear();
Console.WriteLine("Wrong Button");
Console.Clear();
}
