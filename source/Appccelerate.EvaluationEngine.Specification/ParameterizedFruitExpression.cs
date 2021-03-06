//-------------------------------------------------------------------------------
// <copyright file="ParameterizedFruitExpression.cs" company="Appccelerate">
//   Copyright (c) 2008-2012
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.EvaluationEngine
{
    using Appccelerate.EvaluationEngine.Expressions;

    public class ParameterizedFruitExpression : IExpression<int, char>
    {
        public string Kind { get; set; }

        public int Count { get; set; }

        public int Evaluate(char parameter)
        {
            return this.Kind.Length > 0 && this.Kind[0] == parameter ? this.Count : 0;
        }

        public string Describe()
        {
            return "fruit expressions: " + this.Count + " " + this.Kind;
        }
    }
}