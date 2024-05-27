using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//caundo el usuario presione el boton Btn_aceptar debe escribirse un mensaje en la consola
//si el texto del inputpasword coincide con una contraseña predefinida por nostoros
//escribir "access granted"
//sino escribir "access Denied"
public class LoginManager : MonoBehaviour
{
    public string[] passWords;
    public InputField InputPassword;

    // Start is called before the first frame update
    void Start()
    {}
    // Update is called once per frame
    void Update()
    {}

    public void chequearContraseñas()
    {
        for(int i = 0; i < passWords.Length; i++)
        {
            if (InputPassword.text == passWords[i])
            {
                Debug.Log("Access Garanted");
                break;
            }
            else
            {
                Debug.Log("Acces Denied");
                break;
            }
        }
    }
}
