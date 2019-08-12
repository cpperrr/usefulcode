# 实用代码
* J1939
* BIN文件解析
# j1939
* 文件概述
  * can.c
  * can.h
  * Datatype.h
  * test_j1939_can.c
  * test_j1939_can.h
  * test_j1939_common.c
  * test_j1939_common.h
  * test_j1939_tp.c
  * test_j1939_tp.h
* 功能函数描述
  * J1393_Init（）
  * static enum_cm_timeout_type J1939_RefreshCMTimer(uint16_t dt_ms)
  * J1939_CM_Start（）
  * J1939_CAN_TP_Rx（）
  * J1939_SendAbort（）
  * J1939_next_DT_Packet（）
  * void J1939_CAN_Tx(J1939_TX_MESSAGE_T msg)
  * void J1939_Main(uint16_t dt_ms)
  
  
# binfile
* 文件概述
  * readbinapi.cs
* 函数功能描述
  * 读取bin文件后转换成2维数组（1维参数是section长度，2维参数是每个section对应的数据）
  * bin文件和hex文件读取方法不一样
