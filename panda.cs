using System;
using System.Collections.Generic;
using System.Text;

namespace BenPG
{
	public class Panda
	{


	        /// <summary>
	        /// In case of bamboo-related emergency
        	/// </summary>
	        /// <returns>panda</returns>
        	public static string GetPanda()
	        {
        	    var panda = new StringBuilder();
	            panda.AppendLine(@"      ___oo#:#o__                                                ");
        	    panda.AppendLine(@"    o##########o###-                                             ");
	            panda.AppendLine(@"   ####o#~:~#~#####:~o______________                             ");
        	    panda.AppendLine(@"   #####o~ -- ~  ~~~~ ~            ~~--_   _o---~- -o            ");
	            panda.AppendLine(@"   ~-##~_~-__                           ~-~::######oo:o          ");
        	    panda.AppendLine(@"     ~~##-~~ ~   _oooooo___        o_____    ~ ~~~#~##~o_        ");
	            panda.AppendLine(@"   _~~~~     _o##############__  _########o_      #~~~####       ");
        	    panda.AppendLine(@" o~         o#####~~~~~~#####~~ #############o    ~-###_~o       ");
	            panda.AppendLine(@" #o       _####_~  _ooo#o###:   ########~~:###:_   ~####~        ");
	            panda.AppendLine(@"o~        #o####_o_######~#o#    #######-  ~-##_##~#--~          ");
        	    panda.AppendLine(@"#         ###########~~~~:::~     ~######    #######_            ");
        	    panda.AppendLine(@"#          #######:~~~ ~########o_  ######o_o########            ");
	            panda.AppendLine(@"#          -~~~~~~~     ~########~ _#################            ");
        	    panda.AppendLine(@" ~_            _         ~~#~~~ ~ -#~################            ");
	            panda.AppendLine(@"  ~_        _  ~-__       o~        ~~###########~#-             ");
        	    panda.AppendLine(@"   ~o_  -_  #      ~~~~---#              ~~~-~~:_~~              ");
	            panda.AppendLine(@"  _oo_~-_:~~~o             ~o_          ____--~ ~~#__    ____    ");
        	    panda.AppendLine(@"#####o#_-~-~#o #_o---          :#::~#--##~--ooo_o_o###~:    ~~_  ");
	            panda.AppendLine(@"######:o-    ~#_ ~##o_      __-~~####oo_~~~~-_:~ ##o_   ~~o_o-~~ ");
        	    panda.AppendLine(@"######~~~      ~o:~~###o--~~      ~~~####oo_  ~~  ~###  ##o~~-_  ");
	
        	    return panda.ToString();
	        }

	}
}