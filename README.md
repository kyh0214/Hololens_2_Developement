# Hololens_2_Developement
Hololens 2 Developement

This is unity practice project that import .obj files from Microsoft hololens 2 Decvice.

We need to find the path to call our files. 

There are speciel codes that recall file path via C# script.

I find 4 special codes. 

I can use below 4 code.


        f_path[0] = Application.persistentDataPath;
        f_path[1] = Application.streamingAssetsPath;
        f_path[2] = Application.dataPath;
        f_path[3] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);


If you want to know how to use above code go to FindPathP.cs file

Futhermore, If you wanna see that path during hololens application running, go to SeeDebug.cs file

