using Artemis.Core;
using Artemis.Core.Modules;
using WebSocketSharp;
using ArtemisOsu.DataModels;
using System.Collections.Generic;
using System;
using Serilog;
using Newtonsoft.Json;

namespace ArtemisOsu
{
    // The core of your module. Hover over the method names to see a description.
    [PluginFeature(Name = "ArtemisOsu", Icon = "CircleSlice8")]
    public class PluginModule : Module<PluginDataModel>
    {
        private WebSocket _webSocket;
        private readonly ILogger _logger;

        public PluginModule(ILogger logger)
        {
            _logger = logger;
        }

        // This is useful if your module targets a specific game or application.
        // If this list is not null and not empty, the data of your module is only available to profiles specifically targeting it
        public override List<IModuleActivationRequirement> ActivationRequirements { get; } = new()
        {
            new ProcessActivationRequirement("osu!"),
        };
        // This is the beginning of your plugin feature's life cycle. Use this instead of a constructor.
        public override void Enable()
        {

        }

        // This is the end of your plugin feature's life cycle.
        public override void Disable()
        {
            // Make sure to clean up resources where needed (dispose IDisposables etc.)
        }

        public override void ModuleActivated(bool isOverride)
        {
            _webSocket = new WebSocket("ws://127.0.0.1:24050/ws", Array.Empty<string>());
            try
            {
                _webSocket.Connect();
                _webSocket.OnMessage += _webSocket_OnMessage;
                _webSocket.OnClose += _webSocket_OnClose;
                _webSocket.OnError += _webSocket_OnError;
                _webSocket.OnOpen += _webSocket_OnOpen;
                _logger.Information("Connected to websocket");
            }
            catch
            {
                _logger.Error("fucky wucky");
            }
        }

        private void _webSocket_OnOpen(object sender, System.EventArgs e)
        {
            _logger.Information("Websocket opened");
        }

        private void _webSocket_OnError(object sender, ErrorEventArgs e)
        {
            _logger.Information("websocket error");
        }

        private void _webSocket_OnClose(object sender, CloseEventArgs e)
        {
            _logger.Information("websocket closed");
        }

        private void _webSocket_OnMessage(object sender, MessageEventArgs e)
        {
            PluginDataModel pluginDataModel = JsonConvert.DeserializeObject<PluginDataModel>(e.Data);

            DataModel.root = pluginDataModel.root;
            DataModel.gameplay = pluginDataModel.gameplay;
            DataModel.menu = pluginDataModel.menu;
        }

        public override void ModuleDeactivated(bool isOverride)
        {
            // When this gets called your activation requirements are no longer met and your module will stop displaying
            // You can remove this if you don't need it
        }

        public override void Update(double deltaTime)
        {
            // This is where you can add your update logic
        }
    }
}