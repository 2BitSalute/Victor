﻿using System;
using System.Collections.Generic;
using System.Text;

using CommandLine;
using CommandLine.Text;

namespace Victor
{
    public class Options
    {
        [Option('d', "debug", Required = false, HelpText = "Enable debug mode.")]
        public bool Debug { get; set; }
    }

    [Verb("sr", HelpText = "Test the default speech recognition feature of Victor with the default mic as the input source.")]
    class SpeechRecognitionOptions : Options
    {

    }

    [Verb("nlu", HelpText = "Test the NLU feature of Victor.")]
    class NLUOptions : Options
    {
        [Option('m', "model", Required = true, HelpText = "The NLU model to use.")]
        public string Model { get; set; }

        [Option('t', "text", Required = true, HelpText = "The text to understand.")]
        public string Text { get; set; }
    }

    [Verb("tts", HelpText = "Test the TTS feature of Victor.")]
    class TTSOptions : Options
    {
        [Option('t', "text", Required = true, HelpText = "The text to synthesize speech for.")]
        public string Text { get; set; }
    }

    [Verb("cui", HelpText = "Administer the CUI features of Victor (admin only.)")]
    class CUIOptions : Options
    {
        [Option('v', "version", Required = false, Default = 1, HelpText = "Set the version of the object to be retrieved.")]
        public int Version { get; set; }

        [Option("filter", Required = false, Default = null, HelpText = "Filter the current query on this value.")]
        public string Filter { get; set; }

        [Option('i', "input", Required = false, Default = null, HelpText = "Input for the current operation.")]
        public string Input { get; set; }

        [Option('f', "file", Required = false, Default = null, HelpText = "File to use for input or output for the current operation.")]
        public string File { get; set; }

        [Option('w', "overwrite", Required = false, Default = false, HelpText = "Overwrite file to use for input or output for the current operation.")]
        public bool Overwrite { get; set; }

        [Option('j', "json", Required = false, Default = false, HelpText = "Print the JSON recieved for the current operation.")]
        public bool Json { get; set; }

        [Option("get-bots", Required = false, HelpText = "List the current chatbots on the EDDI server.")]
        public bool GetBots { get; set; }

        [Option("get-bot", Required = false, HelpText = "Get the details of the bot with the speicified id.")]
        public string GetBot { get; set; }

        [Option("export-bot", Required = false, HelpText = "Export a chatbot on the EDDI server.")]
        public string ExportBot { get; set; }

        [Option("get-packages", Required = false, HelpText = "List the current packages on the EDDI server.")]
        public bool GetPackages { get; set; }

        [Option("get-package", Required = false, HelpText = "Get the package with the specified id.")]
        public string GetPackage { get; set; }

        [Option("get-dictionary", Required = false, HelpText = "Get the dictionary with the specified id.")]
        public string GetDictionary { get; set; }

        [Option("get-behavior", Required = false, HelpText = "Get the behavior set with the specified id.")]
        public string GetBehavior { get; set; }

        [Option("get-output", Required = false, HelpText = "Get the output with the specified id.")]
        public string GetOutput { get; set; }

        [Option("get-property", Required = false, HelpText = "Get the property with the specified id.")]
        public string GetProperty { get; set; }

        [Option("create-dictionary", Required = false, HelpText = "Create a dictionary from the specified input.")]
        public bool CreateDictionary { get; set; }

        [Option("create-behavior", Required = false, HelpText = "Create a behavior set from the specified input.")]
        public bool CreateBehavior { get; set; }

        [Option("create-output", Required = false, HelpText = "Create an output set from the specified input.")]
        public bool CreateOutput { get; set; }

        [Option("create-package", Required = false, HelpText = "Create a package from the specified input.")]
        public bool CreatePackage { get; set; }

        [Option("start-convo", Required = false, HelpText = "Start a conversation with a bot.")]
        public string StartConversation { get; set; }

        [Option("get-convo", Required = false, HelpText = "Start a conversation with a bot.")]
        public string GetConversation { get; set; }

        [Option('t', "talk", Required = false, HelpText = "Respond to a particular coversation.")]
        public string Talk { get; set; }

        [Option("bid", Required = false, HelpText = "Bot id")]
        public string BotId { get; set; }

        [Option("cid", Required = false, HelpText = "Conservation id")]
        public string ConversationId { get; set; }
    }

    [Verb("cx", HelpText = "Use the CX features of Victor.")]
    public class CXOptions : Options
    {

    }
}
