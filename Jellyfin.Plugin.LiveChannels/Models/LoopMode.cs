namespace Jellyfin.Plugin.LiveChannels.Models;

/// <summary>
/// How a channel arranges its blocks (series and standalone items) into the looping schedule.
/// </summary>
public enum LoopMode
{
    /// <summary>Shuffle the blocks deterministically so no single series dominates.</summary>
    Shuffle = 0,

    /// <summary>Order the blocks alphabetically by title.</summary>
    Alphabetical = 1,

    /// <summary>Order the blocks by release or air date, oldest first.</summary>
    Chronological = 2,

    /// <summary>
    /// Deal one block from each series in turn, alphabetically, and move every series on to its next block each
    /// pass: A 1-2, B 1-2, C 1-2, A 3-4, B 3-4, ... A series that runs out starts over while the others carry on.
    /// </summary>
    RoundRobin = 3
}
