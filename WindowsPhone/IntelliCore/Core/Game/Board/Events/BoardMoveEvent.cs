﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelli.Core.Game.Board.Events
{
    public class BoardMoveEvent : IEvent
    {
        public static readonly String NAME = "BoardMoveEvent";

        private int pid;
        private Position currentPosition;
        private Position nextPosition;

        public string getEventName()
        {
            return NAME;
        }

        public int getPid()
        {
            return this.pid;
        }

        public void setPid(int pid)
        {
            this.pid = pid;
        }

        public BoardMoveEvent(Position current, Position next)
        {
            this.currentPosition = current;
            this.nextPosition = next;
        }

        public Position getCurrentPosition()
        {
            return this.currentPosition;
        }

        public Position getNextPosition()
        {
            return this.nextPosition;
        }

    }
}
