using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Guilds;
using DaggerfallWorkshop.Game.Formulas;
using DaggerfallWorkshop.Game.Entity;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop.Game.Utility;

namespace LanguageBalance
{
  public class LanguageBalanceMod : MonoBehaviour
  {
    static LanguageBalanceMod instance;

    public static LanguageBalanceMod Instance
    {
      get { return instance ?? (instance = FindObjectOfType<LanguageBalanceMod>()); }
    }

    static Mod mod;

    [Invoke(StateManager.StateTypes.Start, 0)]
    public static void Init(InitParams initParams) {
      mod = initParams.Mod;
      instance = new GameObject("LanguageBalance").AddComponent<LanguageBalanceMod>();
      mod.IsReady = true;
    }

    public static void Start() {
      Debug.Log("Language Balance Active");
      public override int GetTrainingMax(DFCareer.Skills skill) {
        int defaultLanguageTrainingMax = 90;
        return (DaggerfallSkills.IsLanguageSkill(skill)) ? defaultLanguageTrainingMax : defaultTrainingMax;
      }
    }
  }
}
