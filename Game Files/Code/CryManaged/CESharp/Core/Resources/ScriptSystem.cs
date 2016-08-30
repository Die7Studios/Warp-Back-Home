// Copyright 2001-2016 Crytek GmbH / Crytek Group. All rights reserved.

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using CryEngine.Resources;
using CryEngine.Components;
using CryEngine.FlowSystem;
using CryEngine.DomainHandler;

namespace CryEngine.Resources
{
	/// <summary>
	/// Interface which must be implemented to allow for an assembly to be automatically instanciated by the framework on runtime. If an assembly holds a class which implements this interface, ScriptSystem will watch the assembly for modifications. If the file is changed, the plugin will be newly instanciated.
	/// </summary>
	public interface ICryEngineAddIn
	{		
		/// <summary>
		/// Supposed to initialize the assembly (e.g. creating managers as well as type registration)
		/// </summary>
		void Initialize(InterDomainHandler handler);

		/// <summary>
		/// Raises the run scene function.
		/// </summary>
		/// <param name="scene">Scene object which originated the event.</param>
		void OnFlowNodeSignal(FlowNode node, PropertyInfo signal);

		/// <summary>
		/// Create game relevant objects and initialize game logic.
		/// </summary>
		void StartGame();

		/// <summary>
		/// End game logic and clean up game revelant objects.
		/// </summary>
		void EndGame();

		/// <summary>
		/// Supposed to cleanup all resources used by the assembly.
		/// </summary>
		void Shutdown();
	}

	/// <summary>
	/// Implements ICryEngineAddIn to ease compatibility in external Add-Ins.
	/// </summary>
	public class CryEngineAddIn : ICryEngineAddIn
	{
		public virtual void Initialize(InterDomainHandler handler)
		{
		}

		public virtual void OnFlowNodeSignal(FlowNode node, PropertyInfo signal)
		{
		}

		public virtual void StartGame()
		{
		}

		public virtual void EndGame()
		{
		}

		public virtual void Shutdown()
		{
		}
	}
}
