/*
               File: Login
        Description: Login
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/10/2026 9:18:15.19
       Program type: Callable routine
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
   public class wlogin : GXWorkpanel
   {
      public wlogin( int hnd ,
                     ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wlogin( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wlogin( IGxContext context ,
                     int hnd ,
                     ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "Login" ;
      }

      public override String getFrmTitle( )
      {
         return "Login" ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return null ;
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
         return 1885 ;
      }

      public override int getFrmHeight( )
      {
         return 832 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WLogin.htm";
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
         return IsMain;
      }

      public override bool isModal( )
      {
         return true ;
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
         return 0 ;
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
         return true ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( out String aP0_Logar )
      {
         this.AV5Logar = "" ;
         executePrivate();
         aP0_Logar=this.AV5Logar;
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
         /* Execute user event: E11V0P2 */
         E11V0P2 ();
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
         /* Execute user event: E12V0P2 */
         E12V0P2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E12V0P2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV5Logar = "N" ;
      }

      public override void GXEnter( )
      {
         /* Execute user event: E13V0P2 */
         E13V0P2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E13V0P2( )
      {
         eventLevelContext();
         /* Enter Routine */
         AV11GXLvl7 = 0 ;
         /* Using cursor W000P2 */
         pr_default.execute(0, new Object[] {AV6PesFunL, AV7PesFunS});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A44PesFunS = W000P2_A44PesFunS[0] ;
            n44PesFunS = W000P2_n44PesFunS[0] ;
            A43PesFunL = W000P2_A43PesFunL[0] ;
            n43PesFunL = W000P2_n43PesFunL[0] ;
            AV11GXLvl7 = 1 ;
            AV8Ret = GXUtil.SetUserId( A43PesFunL, (IGxContext)(context), "DEFAULT") ;
            AV5Logar = "S" ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( ( AV11GXLvl7 == 0 ) )
         {
            AV8Ret = GXUtil.SetUserId( "", (IGxContext)(context), "DEFAULT") ;
            GXutil.msg( me(), "Login ou senha não encontrados!" );
         }
         if ( ( String.CompareOrdinal(AV5Logar.TrimEnd(' '), "S".TrimEnd(' ') ) == 0 ) )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
         eventLevelResetContext();
      }

      protected void nextLoad( )
      {
      }

      protected void E11V0P2( )
      {
         /* Load Routine */
         nextLoad();
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1885 , 832 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavPesfunlogin = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),933, 334, 150, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 933 , 334 , 150 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV6PesFunL" );
         ((GXEdit) edtavPesfunlogin.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesfunlogin.addFocusListener(this);
         edtavPesfunlogin.getGXComponent().setHelpId("HLP_WLogin.htm");
         edtavPesfunsenha = new GUIObjectString ( new GXEdit(20, "@!", UIFactory.getFont( "Courier New", 0, 9),933, 360, 150, 21, GXPanel1, true, ILabelConstants.BORDER_3D, GXTypeConstants.VARCHAR, false, true, UIFactory.getColor(5), false) , GXPanel1 , 933 , 360 , 150 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV7PesFunS" );
         ((GXEdit) edtavPesfunsenha.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavPesfunsenha.addFocusListener(this);
         edtavPesfunsenha.getGXComponent().setHelpId("HLP_WLogin.htm");
         bttbtt6 = UIFactory.getGXButton( GXPanel1 , "Logar" ,  962 ,  403 ,  91 ,  26 , UIFactory.getFont( "MS Shell Dlg", 0, 8) );
         bttbtt6.setTooltip("Logar");
         bttbtt6.addActionListener(this);
         lbllbl4 = UIFactory.getLabel(GXPanel1, "Login", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 884 , 338 , 32 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "Senha", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 884 , 364 , 37 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavPesfunlogin ,
                   edtavPesfunsenha ,
                   bttbtt6
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(edtavPesfunlogin, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      public override void VariablesToControls( )
      {
         edtavPesfunlogin.setValue( AV6PesFunL );
         edtavPesfunsenha.setValue( AV7PesFunS );
      }

      public override void ControlsToVariables( )
      {
         AV6PesFunL = (String)(edtavPesfunlogin.getValue()) ;
         edtavPesfunlogin.setValue(AV6PesFunL);
         AV7PesFunS = (String)(edtavPesfunsenha.getValue()) ;
         edtavPesfunsenha.setValue(AV7PesFunS);
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
         if ( bttbtt6.isEventSource(eventSource) ) {
            /* Execute user event: E13V0P2 */
            E13V0P2 ();
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavPesfunlogin.isEventSource(eventSource) ) {
            setGXCursor( edtavPesfunlogin.getGXCursor() );
            return;
         }
         if ( edtavPesfunsenha.isEventSource(eventSource) ) {
            setGXCursor( edtavPesfunsenha.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavPesfunlogin.isEventSource(eventSource) ) {
            AV6PesFunL = edtavPesfunlogin.getValue() ;
            return;
         }
         if ( edtavPesfunsenha.isEventSource(eventSource) ) {
            AV7PesFunS = edtavPesfunsenha.getValue() ;
            return;
         }
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
            /* Execute user event: E13V0P2 */
            E13V0P2 ();
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
         this.AV5Logar = AV5Logar;
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
         AV11GXLvl7 = 0 ;
         scmdbuf = "" ;
         AV6PesFunL = "" ;
         AV7PesFunS = "" ;
         W000P2_A13PesCodi = new int[1] ;
         W000P2_A44PesFunS = new String[] {""} ;
         W000P2_n44PesFunS = new bool[] {false} ;
         W000P2_A43PesFunL = new String[] {""} ;
         W000P2_n43PesFunL = new bool[] {false} ;
         A44PesFunS = "" ;
         n44PesFunS = false ;
         A43PesFunL = "" ;
         n43PesFunL = false ;
         AV8Ret = 0 ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wlogin__default(),
            new Object[][] {
                new Object[] {
               W000P2_A13PesCodi, W000P2_A44PesFunS, W000P2_n44PesFunS, W000P2_A43PesFunL, W000P2_n43PesFunL
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV11GXLvl7 ;
      protected short AV8Ret ;
      protected String AV5Logar ;
      protected String scmdbuf ;
      protected bool returnInSub ;
      protected bool n44PesFunS ;
      protected bool n43PesFunL ;
      protected String AV6PesFunL ;
      protected String AV7PesFunS ;
      protected String A44PesFunS ;
      protected String A43PesFunL ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected IDataReader W000P2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W000P2_A13PesCodi ;
      protected String[] W000P2_A44PesFunS ;
      protected bool[] W000P2_n44PesFunS ;
      protected String[] W000P2_A43PesFunL ;
      protected bool[] W000P2_n43PesFunL ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectString edtavPesfunlogin ;
      protected GUIObjectString edtavPesfunsenha ;
      protected IGXButton bttbtt6 ;
      protected ILabel lbllbl4 ;
      protected ILabel lbllbl5 ;
      protected String aP0_Logar ;
   }

   public class wlogin__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmW000P2 ;
          prmW000P2 = new Object[] {
          new Object[] {"@AV6PesFunL",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV7PesFunS",SqlDbType.VarChar,20,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W000P2", "SELECT TOP 1 [PesCodigo], [PesFunSenha], [PesFunLogin] FROM [PESSOA] WITH (NOLOCK) WHERE ([PesFunLogin] = @AV6PesFunL) AND ([PesFunSenha] = @AV7PesFunS) ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW000P2,100,0,true,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
