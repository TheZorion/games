using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameIntro.Item
{
    public interface Items
    {
        int GetDefense();
        int GetAttack();
        Type TheType();
        String GetPic();
        String Name();
        int MagicDamage();
        int Damage();

        int Special();
    }
}
