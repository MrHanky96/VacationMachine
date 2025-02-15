﻿using VacationMachine.Enums;
using VacationMachine.Models;
using VacationMachine.ResultHandler.Interfaces;

namespace VacationMachine.ResultHandler
{
    public class MessageBusResultHandler : IResultHandler
    {
        private readonly IMessageBus _messageBus;

        public MessageBusResultHandler(IMessageBus messageBus)
        {
            _messageBus = messageBus;
        }

        public void Handle(EmployeeModel employee, Result result, int daysToTake)
        {
            if (result.Equals(Result.Approved))
            {
                _messageBus.SendEvent(Configuration.GetEventText());
            }
        }
    }
}
