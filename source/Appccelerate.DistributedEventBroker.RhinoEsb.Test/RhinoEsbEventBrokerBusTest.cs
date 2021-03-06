﻿//-------------------------------------------------------------------------------
// <copyright file="RhinoEsbEventBrokerBusTest.cs" company="Appccelerate">
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

namespace Appccelerate.DistributedEventBroker.RhinoEsb
{
    using Appccelerate.DistributedEventBroker.Messages;

    using Moq;

    using Rhino.ServiceBus;

    using Xunit;

    public class RhinoEsbEventBrokerBusTest
    {
        private readonly Mock<IServiceBus> serviceBus;

        private readonly RhinoEsbEventBrokerBus testee;

        public RhinoEsbEventBrokerBusTest()
        {
            this.serviceBus = new Mock<IServiceBus>();

            this.testee = new RhinoEsbEventBrokerBus(this.serviceBus.Object);
        }

        [Fact]
        public void Publish_MustNotifyMessageOnBus()
        {
            var message = new Mock<IEventFired>();

            this.testee.Publish(message.Object);

            this.serviceBus.Verify(bus => bus.Notify(message.Object));
        }
    }
}
