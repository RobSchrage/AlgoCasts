using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// --- Directions
// Given an array and chunk size, divide the array into many subarrays
// where each subarray is of length size
// --- Examples
// chunk([1, 2, 3, 4], 2) --> [[ 1, 2], [3, 4]]
// chunk([1, 2, 3, 4, 5], 2) --> [[ 1, 2], [3, 4], [5]]
// chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
// chunk([1, 2, 3, 4, 5], 4) --> [[ 1, 2, 3, 4], [5]]
// chunk([1, 2, 3, 4, 5], 10) --> [[ 1, 2, 3, 4, 5]]

namespace Main.completed_exercises.chunk
{
    public class ChunkedArray
    {
        public List<List<int>> Execute(List<int> inputList, int chunkSize)
        {
            var chunkedList = new List<List<int>>();

            var chunk = new List<int>() { };
            
            var inputListIndex = 0;
            foreach (var inputListNum in inputList)
            {
                chunk.Add(inputListNum);
                AddChunkToChunkedList(ref chunk, chunkedList, inputListIndex, chunkSize, inputList.Count());
                inputListIndex++;
            }

            return chunkedList;
        }

        private void AddChunkToChunkedList(ref List<int> chunk, List<List<int>> chunkedList, int inputListIndex, int chunkSize, int inputListCount)
        {
            if(chunk.Count() == chunkSize)
            {
                chunkedList.Add(chunk);
                chunk = new List<int>() { };
                return;
            }
            
            if (inputListIndex == inputListCount - 1)
            {   
                chunkedList.Add(chunk);
                return;
            }
        }


        //public List<List<int>> Execute(List<int> inputList, int chunkSize)
        //{
        //    var chunkedList = new List<List<int>> ();

        //    for (int inputListIndex = 0; inputListIndex < inputList.Count; inputListIndex+= chunkSize)
        //    {
        //        var chunk = GetChunk(inputList, inputListIndex, chunkSize);
        //        chunkedList.Add(chunk);
        //    }


        //    return chunkedList;
        //}

        //private static List<int> GetChunk(List<int> inputList, int inputListIndex, int chunkSize)
        //{
        //    var spaceLeft = inputList.Count - inputListIndex;

        //    if(spaceLeft < chunkSize)
        //    {
        //        return inputList.GetRange(inputListIndex, spaceLeft);
        //    }

        //    return inputList.GetRange(inputListIndex, chunkSize);
        //}
    }
}
