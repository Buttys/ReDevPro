using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ReDevPro
{
    public static class Config
    {
        private static string CONFIG_FILE = "system.conf";
        private static char SEPARATOR_CHAR = '=';
        private static char COMMENT_CHAR = '#';

        private static Dictionary<string, string> _fields = new Dictionary<string, string>();
       
        struct Server
        {
            public string Address;
            public int Port;
        };

        private static Dictionary<string, Server> _servers = new Dictionary<string, Server>();

        public static void Load(string[] args)
        {
            try
            {
                LoadArgs(args);

                string filename = CONFIG_FILE;
                if (filename != null)
                {
                    Dictionary<string, string> fileFields = LoadFile(filename);
                    foreach (var pair in fileFields)
                    {
                        if (!_fields.ContainsKey(pair.Key))
                            _fields.Add(pair.Key, pair.Value);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Problem occured while loading config");
            }
        }

        private static void LoadArgs(string[] args)
        {
            for (int i = 0; i < args.Length; ++i)
            {
                string option = args[i];

                int position = option.IndexOf(SEPARATOR_CHAR);

                if (position != -1)
                {
                    string key = option.Substring(0, position).Trim();
                    string value = option.Substring(position + 1).Trim();

                    if (_fields.ContainsKey(key))
                        Console.Write("Config", "Duplicate setting found: " + key);
                    else
                        _fields.Add(key, value);
                }
                else
                    Console.Write("Config", "No separator found for: " + option);
            }
        }

        private static Dictionary<string, string> LoadFile(string filename)
        {
            Dictionary<string, string> fields = new Dictionary<string, string>();
            using (StreamReader reader = new StreamReader(filename))
            {
                int lineNumber = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine().Trim();
                    ++lineNumber;

                    // Ignore empty lines and comments
                    if (line.Length == 0 || line[0] == COMMENT_CHAR)
                        continue;

                    int position = line.IndexOf(SEPARATOR_CHAR);

                    if (position != -1)
                    {
                        string key = line.Substring(0, position).Trim();
                        string value = line.Substring(position + 1).Trim();

                        if (_fields.ContainsKey(key))
                            Console.Write("Config", "Duplicate setting found: " + key);
                        else
                        {
                            //alter how some values are loaded
                            switch (key)
                            {
                                case "use_d3d":
                                    _fields.Add("Enable Direct X", value);
                                    break;
                                case "auto_card_placing":
                                    _fields.Add("Auto Placement", value);
                                    break;
                                case "auto_chain_order":
                                    _fields.Add("Auto Chain", value);
                                    break;
                                case "random_card_placing":
                                    _fields.Add("Random Placement", value);
                                    break;
                                case "no_delay_for_chain":
                                    _fields.Add("No Chain Delay", value);
                                    break;
                                case "mute_opponent":
                                    _fields.Add("Mute Opponents", value);
                                    break;
                                case "mute_spectators":
                                    _fields.Add("Mute Spectators", value);
                                    break;
                                case "save_last_replay":
                                    _fields.Add("Save Last Replay", value);
                                    break;
                                case "control_mode":
                                    _fields.Add("Mouse Mode", value);
                                    break;
                                case "hide_setname":
                                    _fields.Add("Hide Setnames", value);
                                    break;
                                case "hide_chain_button":
                                    _fields.Add("Hide Chain Buttons", value);
                                    break;
                                case "old_replay_mode":
                                    _fields.Add("Old Replay Mode", value);
                                    break;
                                case "enable_sound":
                                    _fields.Add("Enable Sound", value);
                                    break;
                                case "enable_music":
                                    _fields.Add("Enable Music", value);
                                    break;
                                default:
                                    _fields.Add(key, value);
                                    break;
                            }
                        }
                    }
                    else
                        Console.Write("Config", "No separator found for: " + line);
                }
            }
            return fields;
        }

        public static void AddServer(string key, string address, int port)
        {
            if (!_servers.ContainsKey(key))
                _servers.Add(key, new Server() { Address = address, Port = port });
        }

        public static string GetServerIP(string key, string defaultValue = "127.0.0.1")
        {
            if (_servers.ContainsKey(key))
                return _servers[key].Address;
            return defaultValue;
        }

        public static string[] GetServerList()
        {
            return new List<string>(_servers.Keys).ToArray();
        }

        public static int GetServerPort(string key, int defaultValue = 8911)
        {
            if (_servers.ContainsKey(key))
                return _servers[key].Port;
            return defaultValue;
        }

        public static string GetString(string key, string defaultValue = null)
        {
            if (_fields.ContainsKey(key))
                return _fields[key];
            else
                _fields.Add(key, defaultValue);
            return defaultValue;
        }

        public static int GetInt(string key, int defaultValue = 0)
        {
            int value = defaultValue;
            if (_fields.ContainsKey(key))
            {
                if (_fields[key].StartsWith("0x"))
                    value = Convert.ToInt32(_fields[key], 16);
                else
                    value = Convert.ToInt32(_fields[key]);
            }
            else
                _fields.Add(key, defaultValue.ToString());
            return value;
        }

        public static uint GetUInt(string key, uint defaultValue = 0)
        {
            return (uint)GetInt(key, (int)defaultValue);
        }

        public static bool GetBool(string key, bool defaultValue = false)
        {
            bool value = defaultValue;
            if (_fields.ContainsKey(key))
            {
                value =  Convert.ToInt32(_fields[key]) > 0;
            }
            else
                _fields.Add(key, defaultValue ? "1" : "0");
            return value;
        }

        public static void UpdateBool(string key, bool value)
        {
            UpdateString(key, value ? "1" : "0");
        }

        public static void UpdateString(string key, string value)
        {
            if (_fields.ContainsKey(key))
                _fields[key] = value;
            else
                _fields.Add(key, value);
        }

        public static void SaveConfig()
        {
            using (StreamWriter writer = new StreamWriter(CONFIG_FILE))
            {
                writer.WriteLine("#Generated by Re:DevPro");
                foreach (string key in _fields.Keys)
                {
                    //alter how some values are saved
                    switch (key)
                    {
                        case "Enable Direct X":
                            writer.WriteLine("use_d3d = {0}", _fields[key]);
                            break;
                        case "Auto Placement":
                            writer.WriteLine("auto_card_placing = {0}", _fields[key]);
                            break;
                        case "Auto Chain":
                            writer.WriteLine("auto_chain_order = {0}", _fields[key]);
                            break;
                        case "Random Placement":
                            writer.WriteLine("random_card_placing = {0}", _fields[key]);
                            break;
                        case "No Chain Delay":
                            writer.WriteLine("no_delay_for_chain = {0}", _fields[key]);
                            break;
                        case "Mute Opponents":
                            writer.WriteLine("mute_opponent = {0}", _fields[key]);
                            break;
                        case "Mute Spectators":
                            writer.WriteLine("mute_spectators = {0}", _fields[key]);
                            break;
                        case "Save Last Replay":
                            writer.WriteLine("save_last_replay = {0}", _fields[key]);
                            break;
                        case "Mouse Mode":
                            writer.WriteLine("control_mode = {0}", _fields[key]);
                            break;
                        case "Hide Setnames":
                            writer.WriteLine("hide_setname = {0}", _fields[key]);
                            break;
                        case "Hide Chain Buttons":
                            writer.WriteLine("hide_chain_button = {0}", _fields[key]);
                            break;
                        case "Old Replay Mode":
                            writer.WriteLine("old_replay_mode = {0}", _fields[key]);
                            break;
                        case "Enable Sound":
                            writer.WriteLine("enable_sound = {0}", _fields[key]);
                            break;
                        case "Enable Music":
                            writer.WriteLine("enable_music = {0}", _fields[key]);
                            break;
                        default:
                            writer.WriteLine("{0} = {1}", key.ToLower(), _fields[key]);
                            break;
                    }
                }
            }
        }
    }
}
