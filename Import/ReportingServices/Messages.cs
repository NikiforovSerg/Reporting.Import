﻿namespace DevExpress.XtraReports.Import.ReportingServices {
    static class Messages {
        public const string
            NotConvertedControl_Stub = "NOT CONVERTED",
            InvalidFormat_Error = "The specified XML namespace '{0}' of report definition is not supported.",
            ProcessControlLayout_Shape_Error = "The control should not be of XRShape type.",
            ControlLayoutProperty_NotSupported_Format = "Layout property '{0}' is not supported.",
            ControlProperty_NotSupported_Format = "Control property '{0}' is not supported.",
            StyleProperty_NotSupported_Format = "Style property '{0}' with '{1}' value is not supported",
            PaddingProperty_NotSupported_Format = "Padding side '{0}' is not supported.",
            ParameterProperty_NotSupported_Format = "Parameter property '{0}' is not supported.",
            Parameter_DefaultValueProperty_NotSupported_Format = "Parameter's default value property '{0}' is not supported.",
            LayoutGenericError_Format = "Failed to process the '{0}' element under the '{1}' parent with the {2}.",
            NestedMatrix_NotSupported_Format = "Cannot convert Matrix to Detail band inside the '{0}' {1} container, only Band is supported.",
            ImageElement_NotSupported_Format = "Image element '{0}' is not supported.",
            CodeModules_NotSupported = "Code Modules are not supported.",
            Code_NotSupported = "Code is not supported.",
            Variables_NotSupported = "Variables are not supported.",
            DataType_NotSupported_Format = "Unsupported data type: '{0}'.",
            RootElement_NotSupported_Format = "Root element '{0}' is not supported.",
            ReportSectionElement_NotSupported_Format = "Report section '{0}' element is not supported.",
            PageElement_NotSupported_Format = "Page '{0}' element is not supported.",
            StyleElement_NotSupported = "Page Style element is not supported.",
            BodyElement_NotSupported_Format = "Body property '{0}' is not supported.",
            ReportItemsElement_NotSupported_Format = "ReportItems '{0}' element is not supported.",
            ChartControl_NotSupported = "Chart control is not supported.",
            RichParagraphElement_NotSupported_Format = "Rich Paragraph '{0}' element is not supported.",
            TableControl_NotSupported = "Table control is not supported.",
            ListControl_NotSupported = "List control is not supported.",
            ParameterValueSource_NotSupported_Format = "Unsupported parameter values source: '{0}'.",
            Parameter_DynamicListProperty_NotSupported_Format = "Cannot convert the '{0}' property of a parameter's ValidValues.",
            TextAlign_Expression_NotSupported = "Expression for the 'TextAlign' style property is not supported.",
            Border_Expression_NotSupported_Format = "Cannot convert expressions for the Border's '{0}' property.",
            VerticalAlign_Expression_NotSupported = "Expression for the 'VerticalAlign' style property is not supported.",
            ReportMeasureUnit_NotSupported_Format = "Report measure unit '{0}' is not supported.",
            RichTextRunElement_NotSupported_Format = "RichText Run element '{0}' is not supported.",
            RichTextRunStyle_NotSupported_Format = "RichText Run style '{0}' is not supported.",
            RichTextParagraphElement_NotSupported_Format = "RichText Paragraph element '{0}' is not supported.",
            RichTextRunExpression_NotSupported_Format = "Cannot convert the '{0}' RichText with the following Run Expression: '{1}'.",
            LineElement_NotSupported_Format = "Cannot convert the '{0}' Line's '{1}' element.",
            ImageSourceType_NotSupported_Format = "ImageControl SourceType '{0}' is not supported.",
            VisibilityProperty_NotSupported_Format = "The '{0}' property visibility is not supported for the '{1}' control.",
            BorderProperty_NotSupported_Format = "Border property '{0}' with '{1}' value is not supported.",
            StyleExpression_NotSupported_Format = "Expression for the '{0}' style property is not supported.",
            CannotApplyStyleProperty_Format = "Cannot apply the '{0}' style property to the control '{1}'.",
            ControlMultipleDataMembers_NotSupported_Format = "The '{0}' control cannot use multiple scopes in an expression.",
            ControlUsesInvalidScope_Format = "The '{0}' control uses an undefined scope '{1}'.",
            ControlUsesDifferentScope_NotSupported_Format = "The '{0}' control cannot use the '{1}' scope because it differs from the '{2}' report scope.",
            ExpressionParser_AccessToFieldsAndPageArguments_NotSupported = "Cannot create expression to process Data Fields and Page Arguments.",
            ExpressionParser_NotSupportedComponentExpression = "Cannot create expression for the '{0}' component.",
            ExpressionParser_NotSupportedAggregate_Format = "Not supported '{0}' aggregate function.",
            ExpressionParser_FunctionSingleArgument_Format = "The '{0}' function should have a single argument.",
            ExpressionParser_IifOddArguments_Format = "The 'Iif' function should contain an odd number of arguments.",
            ExpressionParser_Code_NotSupported = "Cannot convert code members for expressions. Implement the '{0}' user-defined function to support this behavior in reports. See [the documentation]( https://docs.devexpress.com/XtraReports/DevExpress.XtraReports.Expressions.CustomFunctions.Register(DevExpress.Data.Filtering.ICustomFunctionOperator--)) for details.",
            ExpressionParser_BuiltInCollection_NotSupported_Format = "The '{0}!' collection could not be converted.",
            ExpressionParser_Field_NotSupported_Format = "The '.{0}' field could not be converted.",
            ExpressionParser_GlobalField_NotSupported_Format = "The 'Global.{0}' built-in field could not be converted.",
            ExpressionParser_DateFormat_NotSupported_Format = "The 'DateFormat.{0}' built-in field could not be converted.",
            Expression_FilterOperatorNotSupported_Format = "Cannot convert the '{0}' filter operator.",
            Tablix_NotSupportedInsideTableCell_Format = "Tablix control '{0}' is not supported inside the table cell",
            DataSource_ConnectionParameters_Expression_NotSupported = "Expression value is not supported for connection parameters.",
            DataSource_Element_NotSupported_Format = "Cannot convert the '{0}' DataSource element.",
            DataSource_ExternalConnection_NotSupported = "Cannot process an external data set's connection.",
            DataSource_DataProviderNotSupported_Format = "Cannot convert the '{0}' data provider.",
            DataSource_OleDBDataProviderNotSupported_Format = "Cannot convert the '{0}' OLE DB data provider.",
            DataSource_UnableToDetermineOleDBDataProvider = "Cannot determine an OLE DB provider type by the connection string.",
            DataSource_CannotResolveColumnType_Format = "Cannot resolve the '{0}' column type.",
            DataSource_CannotResolveDataSourceReference_Format = "Cannot resolve the '{0}' data source reference.",
            DataSource_MissingSharedDataSet_Format = "Cannot find the '{0}' shared data set.",
            DataSource_MissingMapping_Format = "Cannot process the '{0}' to '{1}' data set mapping.",
            DataSource_DataSetParameterPropertyNotSupported_Format = "Cannot convert the '{0}' DataSetParameter property.",
            DataSource_CannotResolveDataSet_Format = "Cannot resolve the '{0}' data set. Trying to parse data set schema.",
            DataSource_CannotProcessDataSet_Format = "Cannot process the '{0}' data set.",
            ActionInfo_NotSupported_Format = "Cannot convert the '{0}' control '{1}' action."
        ;
    }
}
