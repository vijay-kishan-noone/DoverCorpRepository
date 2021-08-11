using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Git
    {
    }
}
/*
 Cloning repository:
Step1:    Create repository in github website and name it as MyRepo1
Step2:    Create info.txt file in the MyRepo1
    commit the file
Step3:    Copy the url of MyRepo1
Step4:    open command prompt in the local computer and clone with the url
    git clone repourl      
    
Step5:    To get all files to local computer
    git pull
=====================
Create a file and push to repostiory
Step1:    Create a file
    copy con file4.txt
    this is my fourthfile
    ctrl+z to save
Step2:    Add the file to local repository
    git add file4.txt
Step3:    Commit the file to staging
    git commit -m "Message: Filecreated at local computer"
Step4:    Push to repository
    git push

 */