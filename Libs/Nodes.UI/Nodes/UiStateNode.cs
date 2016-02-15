﻿/*  MyNetSensors 
    Copyright (C) 2015 Derwish <derwish.pro@gmail.com>
    License: http://www.gnu.org/licenses/gpl-3.0.txt  
*/

namespace MyNetSensors.Nodes
{
    public class UiStateNode : UiNode
    {
        public string Value { get; set; }

        public UiStateNode() : base("State", 1, 0)
        {
        }


        public override void OnInputChange(Input input)
        {
            Value = input.Value;
            UpdateMe();
        }


    }
}
