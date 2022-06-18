using System;
using System.Collections.Generic;
using WordNameSpace;

namespace JumperNameSpace
{
    // TODO: Implement the Seeker class as follows...
    public class Jumper
    {
        public List<string> list = new List<string>();
        public bool isJumperDead = false;

        private Word word = new Word();


        public Jumper(){
            makeJumperList();
        }   

        private void makeJumperList()
        {

            list.Add(@"  ___  ");
            list.Add(@"/// \\\");
            list.Add(@"||| |||");
            list.Add(@"\\\ ///");
            list.Add(@" \\ // ");
            list.Add(@"  \ /  ");
            list.Add(@"   |   ");

        }
        public void displayJumper()
        {
            foreach (string line in list){
                Console.WriteLine(line);
            }
        }

        public void removeLine()
        {
        list.RemoveAt(0);
        }

        public void jumperDead()
        {
            if (list.Count == 1){
                isJumperDead = true;
            }

        }

    }
    
}