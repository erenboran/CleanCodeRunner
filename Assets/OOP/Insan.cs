using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health; // Özel bir saðlýk özelliði (private).

    public int Health // Halka açýk bir saðlýk özelliði (public) ve get-set yöntemleri kullanýlarak kapsüllenmiþ.
    {
        get { return health; } // "Health" özelliðine eriþimde deðeri döndürür.
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
        } // "Health" özelliðine eriþimde deðeri ayarlar.
    }

    // Diðer oyuncu yöntemleri, dýþarýdan saðlýk özelliðine eriþim saðlamadan çalýþabilir.
}

