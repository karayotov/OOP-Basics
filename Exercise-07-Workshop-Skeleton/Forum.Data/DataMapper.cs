using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data
{
    class DataMapper 
    {
        //DATA_PATH and CONFIG_PATH are user concatenated to specify where the file should be.

        private const string DATA_PATH = "../data/"; //It will store the directory path were we will store our data (.csv files).
        private const string CONFIG_DATA = "config.ini"; //and it stores the configuration file name
        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv"; //stores the content of the configuration file.


    }
}
