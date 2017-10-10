﻿using System;
namespace FrameworkNamespace
{
    public class ObjectManager
    {
        protected SessionManager[] sessionMgrs;

        private long ownerNo;

        public long OwnerNo
        {
            get 
            {
                return ownerNo;
            }
        }

        public ObjectManager()
        {
            ownerNo = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
        }

        public SessionManager GetSessionManager(int moduleType)
        {
            return sessionMgrs[moduleType];
        }

        public OwnerManager GetOwnerManager(int moduleType)
        {
            return sessionMgrs[moduleType].OwnerMgr;
        }
    }
}
