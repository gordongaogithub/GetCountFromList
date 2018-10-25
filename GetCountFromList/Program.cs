using System;
using System.Collections.Generic;

namespace GetCountFromList
{
    class Program
    {
        /// <summary>
        ///需求：对象集合中，计算相同类型的个数
        ///思路：1,2,3,1,2,1
        ///=>    类型：1，2，3
        ///=>    数量：3，2，1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            //1、初始化集合，并赋值
            List<TestDto> inputList = new List<TestDto>();
            inputList.Add(new TestDto(1));
            inputList.Add(new TestDto(2));
            inputList.Add(new TestDto(3));
            inputList.Add(new TestDto(1));
            inputList.Add(new TestDto(2));
            inputList.Add(new TestDto(1));

            //2、挑出类型
            List<int> typeList = new List<int>();
            foreach (var item in inputList)
            {
                if (!typeList.Contains(item.Type))
                {
                    typeList.Add(item.Type);
                }
            }
            //3、对象集合
            List<TestDto> resultList = new List<TestDto>();
            foreach (var type in typeList)
            {
                TestDto testDto = new TestDto();
                testDto.Qty = 0;
                testDto.Type = type;
                resultList.Add(testDto);
            }
            //4、计算数量
            for (int i = 0; i < typeList.Count; i++)
            {
                foreach (var item in inputList)
                {
                    if (typeList[i] ==item.Type)
                    {
                        resultList[i].Qty += 1;
                    }
                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////////////

        }


    }
}
