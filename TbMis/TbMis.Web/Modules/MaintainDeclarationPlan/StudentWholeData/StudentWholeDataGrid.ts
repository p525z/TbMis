﻿
namespace TbMis.MaintainDeclarationPlan {

    @Serenity.Decorators.registerClass()
    export class StudentWholeDataGrid extends Serenity.EntityGrid<StudentWholeDataRow, any> {
        protected getColumnsKey() { return 'MaintainDeclarationPlan.StudentWholeData'; }
        protected getDialogType() { return StudentWholeDataDialog; }
        protected getIdProperty() { return StudentWholeDataRow.idProperty; }
        protected getLocalTextPrefix() { return StudentWholeDataRow.localTextPrefix; }
        protected getService() { return StudentWholeDataService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
        protected getButtons() {
            var buttons = super.getButtons(); buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);

            return buttons;
        }
    }
}