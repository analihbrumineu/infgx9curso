/*
               File: ControleDeLocadora
        Description: Controle de locadora.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/11/2026 9:2:23.7
       Program type: Main program
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class ucontroledelocadora : GXWorkpanel
   {
      public static int Main( String[] args )
      {
         try
         {
            java.lang.Class thisClass = java.lang.Class.FromType(Type.GetType("GeneXus.Programs.ucontroledelocadora"));
            com.genexus.Application.init(thisClass);
            ucontroledelocadora pgm = new ucontroledelocadora (-1, new ModelContext(thisClass));
            com.genexus.Application.realMainProgram = pgm ;
            pgm.executeCmdLine(args);
            return 0 ;
         }
         catch ( Exception e  )
         {
            GXUtil.SaveToEventLog( "AgoraVaiCurso", e);
            throw e ;
            return 1 ;
         }
      }

      public void executeCmdLine( String[] args )
      {
         execute();
      }

      public ucontroledelocadora( int hnd ,
                                  ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ucontroledelocadora( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public ucontroledelocadora( IGxContext context ,
                                  int hnd ,
                                  ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "ControleDeLocadora" ;
      }

      public override String getFrmTitle( )
      {
         return "Controle de locadora" ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return new bmenuprincipal(context, this) ;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 364 ;
      }

      public override int getFrmHeight( )
      {
         return 158 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WControleDeLocadora.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return true;
      }

      public override bool isModal( )
      {
         return false;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
         /* Execute user event: E11V012 */
         E11V012 ();
      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         standAlone();
         VariablesToControls();
         /* End function GeneXus Refresh */
      }

      public override void GXStart( )
      {
         /* Execute user event: E12V012 */
         E12V012 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V012( )
      {
         eventNoLevelContext();
         /* Start Routine */
         this.setWindowState(2);
         AV6TemFunc = 0 ;
         /* Using cursor W00012 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A38PesTipo = W00012_A38PesTipo[0] ;
            n38PesTipo = W00012_n38PesTipo[0] ;
            A15PesCPF = W00012_A15PesCPF[0] ;
            n15PesCPF = W00012_n15PesCPF[0] ;
            AV6TemFunc = 1 ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( ( AV6TemFunc != 0 ) )
         {
            new pvalpesfunlogin(context, base.remoteHandle, base.context).execute( out  AV5Logar) ;
            if ( ( String.CompareOrdinal(AV5Logar.TrimEnd(' '), "N".TrimEnd(' ') ) == 0 ) )
            {
               if (canCleanup()) {
                  returnInSub = true;
                  this.cleanup();
               }
               if (true) return;
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E11V012( )
      {
         /* Load Routine */
         nextLoad();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 364 , 158 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
      }

      public override void setFocusFirst( )
      {
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void VariablesToControls( )
      {
      }

      public override void ControlsToVariables( )
      {
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
      }

      protected void eventLevelResetContext( )
      {
      }

      protected void reloadGridRow( )
      {
      }

      public override void actionEventDispatch( Object eventSource )
      {
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (triggerEventEnter(eventSource, keyCode)) {
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         stopThreads();
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         returnInSub = false ;
         AV6TemFunc = 0 ;
         scmdbuf = "" ;
         W00012_A13PesCodi = new int[1] ;
         W00012_A38PesTipo = new short[1] ;
         W00012_n38PesTipo = new bool[] {false} ;
         W00012_A15PesCPF = new String[] {""} ;
         W00012_n15PesCPF = new bool[] {false} ;
         A38PesTipo = 0 ;
         n38PesTipo = false ;
         A15PesCPF = "" ;
         n15PesCPF = false ;
         AV5Logar = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ucontroledelocadora__default(),
            new Object[][] {
                new Object[] {
               W00012_A13PesCodi, W00012_A38PesTipo, W00012_n38PesTipo, W00012_A15PesCPF, W00012_n15PesCPF
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV6TemFunc ;
      protected short A38PesTipo ;
      protected String scmdbuf ;
      protected String AV5Logar ;
      protected bool returnInSub ;
      protected bool n38PesTipo ;
      protected bool n15PesCPF ;
      protected String A15PesCPF ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected IDataReader W00012 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W00012_A13PesCodi ;
      protected short[] W00012_A38PesTipo ;
      protected bool[] W00012_n38PesTipo ;
      protected String[] W00012_A15PesCPF ;
      protected bool[] W00012_n15PesCPF ;
      protected GXPanel GXPanel1 ;
   }

   public class ucontroledelocadora__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW00012 ;
          prmW00012 = new Object[] {
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W00012", "SELECT TOP 1 [PesCodigo], [PesTipo], [PesCPF] FROM [PESSOA] WITH (NOLOCK) WHERE [PesTipo] = 2 ORDER BY [PesCPF] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW00012,100,0,true,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
