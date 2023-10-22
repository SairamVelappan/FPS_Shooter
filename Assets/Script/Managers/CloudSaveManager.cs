using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.CloudSave;
using Unity.Services.Core;
using Newtonsoft.Json;

namespace FPS.Manager
{
    public class CloudSaveManager : MonoBehaviour
    {
        public string playerName;
        public int playerGlimmer;
        public int playerSilver;
        public int playerBrightDust;
        public int playerShards;
        PlayerData playerData;
        private async void Start() 
        {
            await UnityServices.InitializeAsync();
            playerData = new PlayerData(300, 30, 500, 700);
        }

        public async void SaveData()
        {
            var playerPos = new Dictionary<string, object> {{"playerData", playerData}};
            await CloudSaveService.Instance.Data.ForceSaveAsync(playerPos);

            Debug.LogError("Saved");
        }

        public async void LoadData()
        {
            var serverData =  await CloudSaveService.Instance.Data.LoadAsync(new HashSet<string> {"playerData"});
            PlayerData _playerData = JsonConvert.DeserializeObject<PlayerData>(serverData["playerData"]);
            // playerName = serverData["name"];
            playerGlimmer = _playerData.glimmer;
            playerSilver = _playerData.silver;
            playerBrightDust = _playerData.brightDust;
            playerShards = _playerData.shards;
            Debug.LogError("DataLoaded");
        }
    }

    [System.Serializable]
    public class PlayerData
    {
        public int glimmer;
        public int silver;
        public int brightDust;
        public int shards;

        public PlayerData(int _glimmer, int _silver, int _brightDust, int _shards)
        {
            this.glimmer = _glimmer;
            this.silver = _silver;
            this.brightDust = _brightDust;
            this.shards = _shards;
        }
    }
}
