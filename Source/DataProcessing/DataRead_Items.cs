using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    class ItemKeys
    {
        public string itemName { get; }
        public string itemCanBePickedip { get; }

        public string DescriptionDefault { get; }

        public string itemGetFailed { get; }

        public string nStart { get; }
        public string nEnd { get; }

        public string vStart { get; }
        public string vEnd { get; }

        // need NONE START/END
        // need verb START/END

        public ItemKeys()
        {
            itemName = "//--ITEM_NAME:";
            itemCanBePickedip = "//--ITEM_CAN_BE_PICKED_UP:";

            DescriptionDefault = "//--ROOM_DESCRIPTION_DEFAULT:";

            itemGetFailed = "//--GET_ITEM_FAILED:";

            nStart = "//--NOUN-START";
            nEnd = "//--NOUN-END";

            vStart = "//--VERB-START";
            vEnd = "//--VERB-END";
        }

    }
    class DataRead_Items
    {
        private List<string> fileData;
        private string fileName;
        private Items item;
        private ItemKeys itemKeys;

        // Return Item() 
        public Items GetItem()
        { return item; }

        public DataRead_Items(string name)
        {
            item = new Items();
            itemKeys = new ItemKeys();
            fileName = name;
            fileData = ReadDataFile.Load_DataFile(FilePaths.Items, fileName);
            ProcessData();
        }

        private void ProcessData()
        {
            //Console.WriteLine("Processing : " + fileName);
            item.name = ReadDataFile.Read_RawSingleLine(itemKeys.itemName, fileData);
            item.PickedupAllowed = ReadDataFile.Read_RawSingleLine(itemKeys.itemCanBePickedip, fileData).Equals("true"); //reads a text string "true" or "false". if that is "equal to true" it returns "bool true", otherwise return "bool false"

            item.description_Default = ReadDataFile.Read_RawSingleLine(itemKeys.DescriptionDefault, fileData);
            item.getItem_Failed = ReadDataFile.Read_RawSingleLine(itemKeys.itemGetFailed, fileData);
        }
    }
}
