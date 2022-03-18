using System;
using UnityEngine;

namespace Data.Char
{
    [Serializable]
    public class CharacterData
    {
        [SerializeField]
        private string Id;

        // Value Range (0-2)
        [SerializeField]
        private int Elite;

        // Value Range (0 - getMaxLevel)
        [SerializeField]
        private int Level;

        [SerializeField]
        private int Experience;

        [SerializeField]
        private int Trust;

        // 元数据 (不存储）
        private CharacterMetadata Data;

        public CharacterData(string id)
        {
            this.Id = id;
        }

        public string GetId() => Id;
        public int GetElite() => Elite;
        public int GetLevel() => Level;
        public int GetExp() => Experience;
        public int GetTrust() => Trust;
        public CharacterMetadata GetCharMeta() => Data != null ? Data : Data = CharManager.Inst().GetMeta(Id);

        public CharAttribute GetAttribute()
        {
            return GetCharMeta().GetLevelAttributes()[Elite] * Level + GetCharMeta().GetEliteAttributes()[Elite];
        }

        public int GetMaxElite()
        {
            return CharacterMetadata.GetMaxElite(Data.GetRarity());
        }

        public int GetMaxLevel()
        {
            return CharacterMetadata.GetMaxLevel(Data.GetRarity(), Elite);
        }

        public int GetMaxExperience()
        {
            return CharacterMetadata.GetMaxExperience(Elite, Level);
        }
    }
}