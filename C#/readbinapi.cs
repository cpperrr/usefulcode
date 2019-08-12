 byte[] binbuf = new byte[UserConfig.FLASH_DATA_BUF_SIZE * UserConfig.FLASH_DATA_BUF_LENGTH];
  public int ReadBin(String pathname)
        {   
	 FileStream f = new FileStream(pathname, FileMode.Open, FileAccess.Read);
        	BinaryReader br;
  	try
                {   
                    br= new BinaryReader(f);
                    filelenth = f.Length;
                    if(filelenth%1024==0)
                    sectionnum=(int)(filelenth/1024);
                    else
                    sectionnum = (int)(filelenth/1024+1);
                  
                    br.Read(binbuf,0,(int)filelenth);
                    Flash_SectionNum = sectionnum;
                    for (i = 0; i < sectionnum; i++)
                    {
                        for (j = 0; j < 1024; j++)
                        { 
                            flash_Data[i].data[j] = binbuf[j+i*1024]; 
                        }                      
                    }

                    br.Close();
                    f.Close();
                  

                }
}