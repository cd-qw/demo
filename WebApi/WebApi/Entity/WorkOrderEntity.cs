using SqlSugar;

namespace WebApi.Entity;

 /// <summary>
 /// 工单表
 /// </summary>
 [SugarTable("NC_WORKORDER")]
 public class WorkOrderEntity
 {

     /// <summary>
     /// 主键d
     /// </summary>
     [SugarColumn(ColumnName = "NID", IsPrimaryKey = true, IsIdentity = false)]
     public string Nid { get; set; }


     /// <summary>
     /// 订单ID
     /// </summary>
     [SugarColumn(ColumnName = "ORDER_ID")]
     public string OrderId { get; set; }


     /// <summary>
     /// 订单号
     /// </summary>
     [SugarColumn(ColumnName = "ORDER_CODE")]
     public string OrderCode { get; set; }


     /// <summary>
     /// 工单编码
     /// </summary>
     [SugarColumn(ColumnName = "WORKORDER_CODE")]
     public string WorkorderCode { get; set; }


     /// <summary>
     /// 拆分时父工单ID,空值未拆分
     /// </summary>
     [SugarColumn(ColumnName = "WORKORDER_PARENT_CODE")]
     public string WorkorderParentCode { get; set; }


     /// <summary>
     /// 工艺ID
     /// </summary>
     [SugarColumn(ColumnName = "PROCESS_ID")]
     public string ProcessId { get; set; }


     /// <summary>
     /// 工艺编号
     /// </summary>
     [SugarColumn(ColumnName = "PROCESS_CODE")]
     public string ProcessCode { get; set; }


     /// <summary>
     /// 产品编号
     /// </summary>
     [SugarColumn(ColumnName = "PRODUCT_CODE")]
     public string ProductCode { get; set; }


     /// <summary>
     /// 产品名称
     /// </summary>
     [SugarColumn(ColumnName = "PRODUCT_NAME")]
     public string ProductName { get; set; }

     /// <summary>
     /// 产品版本
     /// </summary>
     [SugarColumn(ColumnName = "PRODUCT_VERSION")]
     public string ProductVersion { get; set; }
     /// <summary>
     /// 零件图号 
     ///</summary>
     [SugarColumn(ColumnName = "PART_NO")]
     public string PartNo { get; set; }

     /// <summary>
     /// 批次号
     /// </summary>
     [SugarColumn(ColumnName = "BATCH_NO")]
     public string BatchNo { get; set; }

     /// <summary>
     /// 新批次号（40所用）
     /// </summary>
     [SugarColumn(ColumnName = "NBATCH_NO")]
     public string NbatchNo { get; set; }


     /// <summary>
     /// 型号
     /// </summary>
     [SugarColumn(ColumnName = "MODEL_CODE")]
     public string ModelCode { get; set; }


     /// <summary>
     /// 生产模式（0批产，1单件）
     /// </summary>
     [SugarColumn(ColumnName = "PRODUCTION_MODE")]
     public decimal? ProductionMode { get; set; }


     /// <summary>
     /// 入库模式（0：正常入库 1：虚拟入库）
     /// </summary>
     [SugarColumn(ColumnName = "INSTORE_MODE")]
     public decimal? InstoreMode { get; set; }


     /// <summary>
     /// 目标库房
     /// </summary>
     [SugarColumn(ColumnName = "TARGET_STORE")]
     public string TargetStore { get; set; }


     /// <summary>
     /// 生产数量（订单数量+工艺余量）
     /// </summary>
     [SugarColumn(ColumnName = "PRO_QTY")]
     public decimal ProQty { get; set; }


     /// <summary>
     /// 订单数量
     /// </summary>
     [SugarColumn(ColumnName = "ORDER_QTY")]
     public decimal OrderQty { get; set; }


     /// <summary>
     /// 工艺余量（初始默认为0，可调整）
     /// </summary>
     [SugarColumn(ColumnName = "MARGIN_QTY")]
     public decimal MarginQty { get; set; }


     /// <summary>
     /// 10、新建
     ///20、下发
     ///30、生产中
     ///40、暂停
     ///50、拆分
     ///60、Complete（完成）
     ///70、Aborted（终止）
     ///80 冻结
     /// </summary>
     [SugarColumn(ColumnName = "WORKORDER_STATE")]
     public decimal WorkorderState { get; set; }


     /// <summary>
     /// 10、新建
     ///20、下发
     ///30、生产中
     ///40、暂停
     ///50、拆分
     ///60、Complete（完成）
     ///70、Aborted（终止）
     /// </summary>
     [SugarColumn(ColumnName = "PRE_WORKORDER_STATE")]
     public decimal PreWorkorderState { get; set; }


     /// <summary>
     /// 计划标记
     /// </summary>
     [SugarColumn(ColumnName = "PLAN_MARK")]
     public string PlanMark { get; set; }


     /// <summary>
     /// 质量等级
     /// </summary>
     [SugarColumn(ColumnName = "QUALITY_LEVEL")]
     public string QualityLevel { get; set; }


     /// <summary>
     /// 优先级（1，2，3，4，5，6），由低到高
     /// </summary>
     [SugarColumn(ColumnName = "PRIORITY")]
     public decimal? Priority { get; set; }


     /// <summary>
     /// 0、订单创建工单  1：返修计划 2,临时通知单计划  3, 临时工装计划  4,返工计划  5,报废补投计划
     /// </summary>
     [SugarColumn(ColumnName = "WORKORDER_TYPE")]
     public decimal? WorkorderType { get; set; }


     /// <summary>
     /// 生产顺序号（用于排序，初始时默认为令号批次顺序号，可调整）
     /// </summary>
     [SugarColumn(ColumnName = "SEQ")]
     public decimal? Seq { get; set; }


     /// <summary>
     /// 令号批次顺序
     /// </summary>
     [SugarColumn(ColumnName = "ORIGINAL_SEQ")]
     public decimal? OriginalSeq { get; set; }


     /// <summary>
     /// 计划开始时间
     /// </summary>
     [SugarColumn(ColumnName = "PLAN_STARTTIME")]
     public System.DateTime? PlanStarttime { get; set; }


     /// <summary>
     /// 计划结束时间
     /// </summary>
     [SugarColumn(ColumnName = "PLAN_ENDTIME")]
     public System.DateTime? PlanEndtime { get; set; }


     /// <summary>
     /// 实际开始时间
     /// </summary>
     [SugarColumn(ColumnName = "ACTUAL_STARTTIME")]
     public System.DateTime? ActualStarttime { get; set; }


     /// <summary>
     /// 实际结束时间
     /// </summary>
     [SugarColumn(ColumnName = "ACTUAL_ENDTIME")]
     public System.DateTime? ActualEndtime { get; set; }


     /// <summary>
     /// 交货日期（合同日期）
     /// </summary>
     [SugarColumn(ColumnName = "DELIVERY_DATE")]
     public System.DateTime? DeliveryDate { get; set; }


     /// <summary>
     /// 内控时间
     /// </summary>
     [SugarColumn(ColumnName = "INTERNALCONTROL_TIME")]
     public System.DateTime? InternalcontrolTime { get; set; }


     /// <summary>
     /// 责任部门ID
     /// </summary>
     [SugarColumn(ColumnName = "DEPT_ID")]
     public string DeptId { get; set; }


     /// <summary>
     /// 责任部门编码
     /// </summary>
     [SugarColumn(ColumnName = "DEPT_CODE")]
     public string DeptCode { get; set; }


     /// <summary>
     /// 责任部门名称
     /// </summary>
     [SugarColumn(ColumnName = "DEPT_NAME")]
     public string DeptName { get; set; }


     /// <summary>
     /// 车间ID
     /// </summary>
     [SugarColumn(ColumnName = "WORKSHOP_ID")]
     public string WorkshopId { get; set; }


     /// <summary>
     /// 车间编号
     /// </summary>
     [SugarColumn(ColumnName = "WORKSHOP_CODE")]
     public string WorkshopCode { get; set; }


     /// <summary>
     /// 车间名称
     /// </summary>
     [SugarColumn(ColumnName = "WORKSHOP_NAME")]
     public string WorkshopName { get; set; }


     /// <summary>
     /// 当前工序号05,10
     /// </summary>
     [SugarColumn(ColumnName = "CURRENT_OPERATIONSEQ")]
     public string CurrentOperationseq { get; set; }


     /// <summary>
     /// 当前工序
     /// </summary>
     [SugarColumn(ColumnName = "CURRENT_OPERATIONNAME")]
     public string CurrentOperationname { get; set; }


     /// <summary>
     /// 下发时间
     /// </summary>
     [SugarColumn(ColumnName = "SEND_TIME")]
     public System.DateTime? SendTime { get; set; }


     /// <summary>
     /// 密级编码：0、公开；1、内部；2、秘密；3、机密
     /// </summary>
     [SugarColumn(ColumnName = "SECRET_CLASSIFICATION_CODE")]
     public decimal? SecretClassificationCode { get; set; }


     /// <summary>
     /// 密级名称
     /// </summary>
     [SugarColumn(ColumnName = "SECRET_CLASSIFICATION_NAME")]
     public string SecretClassificationName { get; set; }


     /// <summary>
     /// 创建人id
     /// </summary>
     [SugarColumn(ColumnName = "CREATE_USER_ID")]
     public string CreateUserId { get; set; }


     /// <summary>
     /// 创建人编码
     /// </summary>
     [SugarColumn(ColumnName = "CREATE_USER_CODE")]
     public string CreateUserCode { get; set; }


     /// <summary>
     /// 创建人名称
     /// </summary>
     [SugarColumn(ColumnName = "CREATE_USER_NAME")]
     public string CreateUserName { get; set; }


     /// <summary>
     /// 创建时间
     /// </summary>
     [SugarColumn(ColumnName = "CREATE_TIME")]
     public System.DateTime CreateTime { get; set; }


     /// <summary>
     /// 修改人ID
     /// </summary>
     [SugarColumn(ColumnName = "UPDATE_USER_ID")]
     public string UpdateUserId { get; set; }


     /// <summary>
     /// 修改人编码
     /// </summary>
     [SugarColumn(ColumnName = "UPDATE_USER_CODE")]
     public string UpdateUserCode { get; set; }


     /// <summary>
     /// 修改人名称
     /// </summary>
     [SugarColumn(ColumnName = "UPDATE_USER_NAME")]
     public string UpdateUserName { get; set; }


     /// <summary>
     /// 修改时间
     /// </summary>
     [SugarColumn(ColumnName = "UPDATE_TIME", IsOnlyIgnoreInsert = true)]
     public System.DateTime UpdateTime { get; set; }


     /// <summary>
     /// 0、未删除；1、已删除
     /// </summary>
     [SugarColumn(ColumnName = "IS_DELETE")]
     public decimal? IsDelete { get; set; }


     /// <summary>
     /// 0、未冻结；1、冻结
     /// </summary>
     [SugarColumn(ColumnName = "IS_FROZEN")]
     public decimal? IsFrozen { get; set; }


     /// <summary>
     /// 备注
     /// </summary>
     [SugarColumn(ColumnName = "REMARK")]
     public string Remark { get; set; }


     /// <summary>
     /// 完成数量
     /// </summary>
     [SugarColumn(ColumnName = "COMPLETED_QUANTITY")]
     public decimal? CompletedQuantity { get; set; }


     /// <summary>
     /// 入库数量
     /// </summary>
     [SugarColumn(ColumnName = "RECEIPT_QUANTITY")]
     public decimal? ReceiptQuantity { get; set; }


     /// <summary>
     /// 电子文件
     /// </summary>
     [SugarColumn(ColumnName = "ELECTRONIC_DOC_STATUS")]
     public decimal? ElectronicDocStatus { get; set; }

     /// <summary>
     /// 工装状态
     /// </summary>
     [SugarColumn(ColumnName = "TOOLING_STATUS")]
     public decimal? ToolingStatus { get; set; }


     /// <summary>
     /// 物料状态
     /// </summary>
     [SugarColumn(ColumnName = "MATERIAL_STATUS")]
     public decimal? MaterialStatus { get; set; }


     /// <summary>
     /// 军工
     /// </summary>
     [SugarColumn(ColumnName = "MILITARY")]
     public decimal? Military { get; set; }


     /// <summary>
     /// 航天
     /// </summary>
     [SugarColumn(ColumnName = "SPACEFLIGHT")]
     public decimal? Spaceflight { get; set; }

     /// <summary>
     /// 令号批次
     /// </summary>
     [SugarColumn(ColumnName = "ORDER_NO_BATCH")]
     public string OrderNoBatch { get; set; }

     /// <summary>
     /// 工艺版本
     /// </summary>
     [SugarColumn(ColumnName = "PROCESS_VERSION")]
     public string ProcessVersion { get; set; }
     /// <summary>
     /// 是否打印路线卡（0：未打印 1：已打印）
     /// </summary>
     [SugarColumn(ColumnName = "IS_PRINT_ROUTE", DefaultValue = "0")]
     public decimal? IsPrintRoute { get; set; }



     /// <summary>
     /// 0,首序非外协；1，首序外协且不带料；2，首序外协且带料
     ///</summary>
     [SugarColumn(ColumnName = "OUTSOURCE_WITH_MATERIAL")]
     public int OutsourceWithMaterial { get; set; }


     /// <summary>
     /// 项目号 
     ///</summary>
     [SugarColumn(ColumnName = "PROJECT_NUM")]
     public string ProjectNum { get; set; }
     /// <summary>
     /// 原作业计划ID(最初的作业计划) 
     ///</summary>
     [SugarColumn(ColumnName = "ORIGINAL_WORKORDER_ID")]
     public string OriginalWorkorderId { get; set; }
     /// <summary>
     /// 原作业计划号(最初的作业计划) 
     ///</summary>
     [SugarColumn(ColumnName = "ORIGINAL_WORKORDER_CODE")]
     public string OriginalWorkorderCode { get; set; }
     /// <summary>
     /// 原生产计划ID(最初的生产计划) 
     ///</summary>
     [SugarColumn(ColumnName = "ORIGINAL_ORDER_ID")]
     public string OriginalOrderId { get; set; }
     /// <summary>
     /// 原生产计划号(最初的生产计划) 
     ///</summary>
     [SugarColumn(ColumnName = "ORIGINAL_ORDER_CODE")]
     public string OriginalOrderCode { get; set; }
     /// <summary>
     /// 父工单ID 
     ///</summary>
     [SugarColumn(ColumnName = "WORKORDER_PARENT_ID")]
     public string WorkorderParentId { get; set; }
     /// <summary>
     /// 返工返修发起工序ID 
     ///</summary>
     [SugarColumn(ColumnName = "INITIATE_OPERATION_ID")]
     public string InitiateOperationId { get; set; }
     /// <summary>
     /// 是否拆分 
     ///</summary>
     [SugarColumn(ColumnName = "IS_SPLIT", DefaultValue = "0")]
     public decimal IsSplit { get; set; }

     [SugarColumn(ColumnName = "IN_WAREHOUSE_DATE")]
     public System.DateTime? InWarehouseDate { get; set; }

     [SugarColumn(ColumnName = "MANNUAL_COMPLETION_DATE")]
     public System.DateTime? MannualCompletionDate { get; set; }

     [SugarColumn(ColumnName = "MANNUAL_COMPLETION_OPERATOR")]
     public string MannualCompleOperator { get; set; }

     [SugarColumn(IsIgnore = true)]
     public int RemarkStatus { get; set; }
     [SugarColumn(IsIgnore = true)]
     public int DocStatus { get; set; }

     /// <summary>
     /// 缺料数
     /// </summary>
     [SugarColumn(IsIgnore = true)]
     public int LackQty { get; set; }
     [SugarColumn(IsIgnore = true)]
     public decimal NeedTotalCount { get; set; }
     [SugarColumn(IsIgnore = true)]
     public decimal AlreadyCount { get; set; }
     [SugarColumn(IsIgnore = true)]
     public decimal OutCount { get; set; }
     [SugarColumn(IsIgnore = true)]
     public decimal LackCount { get; set; }
     [SugarColumn(IsIgnore = true)]
     public DateTime PredictSetTime { get; set; }
     [SugarColumn(IsIgnore = true)]
     public string DemandDepartmentName { get; set; }
     [SugarColumn(IsIgnore = true)]
     public string DemandPerson { get; set; }

     [SugarColumn(IsIgnore = true)]
     public string Planner { get; set; }

     /// <summary>
     /// 优先级 (令号批次冗余)
     ///</summary>
     [SugarColumn(ColumnName = "N_PRIORITY")]
     public int NPriority { get; set; }

     /// <summary>
     /// 实验要求 (冗余)
     /// </summary>
     [SugarColumn(ColumnName = "VDEF18")]
     public string vdef18 { get; set; }

     [SugarColumn(IsIgnore =true)]
     public int OrderBatchPriority { get; set; }

     [SugarColumn(IsIgnore = true)]
     public string TargetStoreName { get; set; }
     [SugarColumn(IsIgnore = true)]
     public string PlanScheme { get; set; }
     
     [SugarColumn(IsIgnore = true)]
     public string WOKR_ORDER_CODE { get; set; }
     [SugarColumn(IsIgnore = true)]
     public DateTime? PLAN_START_TIME { get; set; }
     [SugarColumn(IsIgnore = true)]
     public string MODEL_CODE { get; set; }
     [SugarColumn(IsIgnore = true)]
     public string PART_NO { get; set; }
     [SugarColumn(IsIgnore = true)]
     public string PRODUCT_CODE { get; set; }
     [SugarColumn(IsIgnore = true)]
     public string PRODUCT_NAME { get; set; }
     //[SugarColumn(IsIgnore = true)]
     //public string Military { get; set; }
     [SugarColumn(IsIgnore = true)]
     public short MATERIAL_STATUS { get; set; }
     [SugarColumn(IsIgnore = true)]
     public decimal? ReworkQty { get; set; }

     [SugarColumn(IsIgnore = true)]
     public string DemandPersonName { get; set; }
     /// <summary>
     /// 材料应发数
     /// </summary>
     [SugarColumn(IsIgnore = true)]
     public decimal? MatSentQty { get; set; }

     /// <summary>
     /// 材料实发数
     /// </summary>
     [SugarColumn(IsIgnore = true)]
     public decimal? RealHairQty { get; set; }
     /// <summary>
     /// 所有工序废品和
     /// </summary>
     [SugarColumn(IsIgnore = true)]
     public decimal? ScrapQty { get; set; }

     /// <summary>
     ///折合工时
     /// </summary>
     [SugarColumn(IsIgnore = true)]
     public int? OperaTotalHour { get; set; }

     /// <summary>
     /// 待入库数量
     /// </summary>
     [SugarColumn(IsIgnore = true)]
     public decimal? AwaitWareHouseQty { get; set; }

     #region 西部材料

     /// <summary>
     /// 计量单位
     /// </summary>
     [SugarColumn(ColumnName = "Unit",IsNullable = true, ColumnDescription = "计量单位")]
     public string Unit { set; get; }

     

     /// <summary>
     /// 合同号
     /// </summary>
     [SugarColumn(ColumnName = "Contract_Number", IsNullable = true, ColumnDescription = "合同号")]
     public string ContractNumber { set; get; }

     [SugarColumn(ColumnName = "Brand",IsNullable = true,ColumnDescription = "牌号")]
     public string Brand { set; get; }

     [SugarColumn(ColumnName = "Spec", IsNullable = true, ColumnDescription = "规格")]
     public string Spec { set; get; }


     [SugarColumn(ColumnName = "Unqualified_Code",IsNullable = true,ColumnDescription = "不合格评审单编号")]
     public string UnqualifiedCode { set; get; }

     #endregion
 }