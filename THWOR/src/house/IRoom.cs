﻿using THWOR.src.items;
using THWOR.src.rooms;
using System.Collections.Generic;
using THWOR.src.characters;

namespace THWOR.src.core.models.rooms
{
    interface IRoom
    {
        #region Room Info

        RoomId GetId();

        string GetName();

        string GetDescription();

        #endregion

        #region Inventory Methods

        /// <summary>
        /// Returns a list of the available items in the room
        /// TODO: modify for item type
        /// </summary>
        /// <returns></returns>
        List<IItem> GetItems();

        /// <summary>
        /// Adds an item to the room's list of available items
        /// TODO: modify for item type
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool AddItem(IItem item);

        /// <summary>
        /// Removes an item from the room's list of available items
        /// TODO: modify for item type
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool RemoveItem(IItem item);

        string SearchBasic(string objectName = null);

        #endregion

        #region Navigation

        //bool CanLeave();

        /// <summary>
        /// Return roomId if direction is valid, -1 if direction is invalid,
        /// and -2 if a different message is generated by the room itself (door locked, etc.)
        /// TODO: modify this to be better
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        RoomId Go(string direction);

        #endregion

        #region Monster/Combat

        /**
         * If the room itself contains a monster, this returns a reference to that monster
         * Used to decide if the player is able to leave a room
         * @return reference to the monster contained by the room
         */
        SimpleMonster getMonster();

        string GenerateMonster(string name);

        #endregion

        #region CustomMethods

        /// <summary>
        /// For room-specific actions and puzzles, etc.
        /// </summary>
        /// <param name="inputs">inputs to parse</param>
        void PerformCustomMethods(string[] inputs);

        #endregion
    }
}
