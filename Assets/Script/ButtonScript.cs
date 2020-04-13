using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class ButtonScript : MonoBehaviour
    {
        
        // Start is called before the first frame update
        public void Onckick()
        {
            var btnName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        
            Debug.Log(btnName);

            var menu = GameObject.Find(btnName).transform.parent.gameObject;
            
            Debug.Log(menu.name);
            
            switch(menu.name){

                case "MainMenu":

                    switch (btnName)
                    {
                        case "StartBtn":
                            OpenMenu("SelectGame");
                            break;
                        case "RankingBtn":
                            OpenMenu("ShowRanking");
                            break;
                    }
                    
                    break;
                case "SelectGame":
                    SelectGame(btnName);
                    break;
                case "ShowRanking":
                    break;
                
            }

        }

        /// <summary>
        /// 指定した名前のuiを開く
        /// </summary>
        /// <param name="name">uiの名前</param>
        public static void OpenMenu(string name)
        {
            InitMenu();
            
            StartUp.uiObject.transform.Find(name).gameObject.SetActive(true);
            
        }

        /// <summary>
        /// 表示してるuiをすべて削除　初期化をする
        /// </summary>
        private static void InitMenu()
        {
            for (int i = 0; i < StartUp.uiObject.transform.childCount; i++)
            {
                StartUp.uiObject.transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        private void SelectGame(string name)
        {
            switch (name)
            {
                case "Cancel":
                    OpenMenu("MainMenu");
                    break;
                
            }
            
        }
    }
}
