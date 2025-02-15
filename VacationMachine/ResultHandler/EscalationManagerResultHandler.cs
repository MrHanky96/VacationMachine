﻿using VacationMachine.Enums;
using VacationMachine.Models;
using VacationMachine.ResultHandler.Interfaces;

namespace VacationMachine.ResultHandler
{
    public class EscalationManagerResultHandler : IResultHandler
    {
        private readonly IEscalationManager _escalationManager;

        public EscalationManagerResultHandler(IEscalationManager escalationManager)
        {
            _escalationManager = escalationManager;
        }

        public void Handle(EmployeeModel employee, Result result, int daysToTake)
        {
            if (result.Equals(Result.Manual))
            {
                _escalationManager.NotifyNewPendingRequest(employee.Id);
            }
        }
    }
}
