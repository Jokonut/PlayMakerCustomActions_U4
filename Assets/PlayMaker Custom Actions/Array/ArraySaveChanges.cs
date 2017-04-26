﻿// (c) Copyright HutongGames, LLC 2010-2017. All rights reserved.
/*--- __ECO__ __PLAYMAKER__ __ACTION__ ---*/

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Array)]
	[Tooltip("Save changes internally for all values edited to be reflected properly. Use this only if you have such a case")]
	public class ArraySaveChanges : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Array Variable to use.")]
		public FsmArray array;

		
		public override void Reset()
		{
			array = null;
		}
		
		public override void OnEnter()
		{
			array.SaveChanges();
			Finish();
		}

		
	}
	
}

