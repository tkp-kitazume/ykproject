<?php    
    defined('C5_EXECUTE') or die('Access_Denied.');    
    session_start();
?>
       <div class="container">
            <div class="row">            
                 <div class="col-sm-6 bg-primary"><span class="text-white"><h2><?=$title;?></h2></span></div>
                 </div>             
        </div>
        <div class="container">
            <div class="row">
                <div class="bg-danger">
                   <div class="col-sm-1 bg-danger" style="padding:5px;">ID</div>
                   <div class="col-sm-3 bg-danger" style="padding:5px;">商品名</div>
                   <div class="col-sm-1 bg-danger" style="padding:5px;">商品価格</div>
                   <div class="col-sm-1 bg-danger" style="padding:5px;">編集</div>
                </div>
             </div>           
<?php
        //Expressから商品一覧を取得
        $entity = Express::getObjectByHandle('goodsample');
        $list = new \Concrete\Core\Express\EntryList($entity);
        $result = $list->getResults();        
        
        //各商品データを画面にグリッド表示
        if (count($result) > 0){
            foreach ($result as $sampledata){
                $sid = $sampledata->getSid();
                $sname = $sampledata->getSname();
                $sprice = $sampledata->getSprice();                     
?>           
                <div class="row">                    
                        <div class="col-sm-1"><?=$sid?></div>
                        <div class="col-sm-3"><?=$sname?></div>
                        <div class="col-sm-1"><?=$sprice?></div>
                        <div class="col-sm-1"><button type="button" name="editbtn" onclick="location.href='https://demo.survey-support.jp/test/index.php/shosai?i=<?=$sid?>'">編集</button></div>                              
                </div>                        
<?php
                                                       
            }
        }
?>  
  