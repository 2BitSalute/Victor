﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Victor
{
    public abstract class CUIController : Api
    {
        #region Constructors
        public CUIController(string name, CancellationToken ct) : base(ct)
        {
            Name = name;
        }

        public CUIController(string name) : this(name, Ct) {}

        public CUIController(string name, CancellationToken ct, params CUIPackage[] packages) : this(name, ct)
        {
            Packages.AddRange(packages.ToList());
        }

        #endregion

        #region Properties
        public string Name { get; }

        public List<CUIPackage> Packages { get; } = new List<CUIPackage>();
        
        public Stack<CUIContext> Context { get; } = new Stack<CUIContext>();
        
        public CUIPackage HomePackage { get; protected set; }
        
        public CUIPackage ActivePackage { get; protected set; }

        public bool DebugEnabled { get; set; }

        public bool InputEnabled { get; set; }

        public Intent LastIntent { get; set; }

        public Action<Intent> LastAction { get; set; }

        #endregion

        #region Abstract methods
        public abstract void Start();

        public abstract void Prompt();

        public abstract void HandleInput(DateTime time, string input);

        public abstract void SayInfo(string template, params object[] args);

        public abstract void SayInfoLine(string template, params object[] args);

        public abstract void SayErrorLine(string template, params object[] args);

        public abstract void StartBeeper();

        public abstract void StopBeeper();
        #endregion

        #region Methods
        public void SetContext(string c, Intent intent, Action<Intent> action) => Context.Push(new CUIContext(DateTime.Now, c, intent, action));
        
        #endregion
    }
}