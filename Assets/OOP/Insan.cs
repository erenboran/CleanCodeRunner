using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health; // �zel bir sa�l�k �zelli�i (private).

    public int Health // Halka a��k bir sa�l�k �zelli�i (public) ve get-set y�ntemleri kullan�larak kaps�llenmi�.
    {
        get { return health; } // "Health" �zelli�ine eri�imde de�eri d�nd�r�r.
        set
        {
            if (value < 0)
            {
                health = 0;
            }
            else
            {
                health = value;
            }
        } // "Health" �zelli�ine eri�imde de�eri ayarlar.
    }

    // Di�er oyuncu y�ntemleri, d��ar�dan sa�l�k �zelli�ine eri�im sa�lamadan �al��abilir.
}

