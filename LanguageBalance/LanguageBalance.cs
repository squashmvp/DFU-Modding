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

namespace LanguageBalance {
  public class LanguageBalanceMod : MonoBehaviour {
    static Mod mod;
    [Invoke(StateManager.StateTypes.Start, 0)]

    public static void Init(InitParams initParams) {
      mod = initParams.mod;
      var go = new GameObject(mod.Title);
      go.AddComponent<LanguageBalanceMod>();
    }

    void Awake() {
      Start();
      mod.IsReady = true;
    }

    public static void Start() {
      public override int GetTrainingMax(DFCareer.Skills skill) {
        int defaultLanguageTrainingMax = 90;
        return (DaggerfallSkills.IsLanguageSkill(skill)) ? defaultLanguageTrainingMax : defaultTrainingMax;
      }
    }
  }
}
