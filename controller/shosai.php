<?php    
    namespace Application\Block\ExternalForm\Form\Controller;
    use Concrete\Core\Controller\AbstractController;
    use Core;
    use Express;
    session_start();

    class Shosai extends AbstractController{
                
        public function view(){             
            //view()は、外部フォームが開いたときの設定を記述します。
            if (isset($_GET['i']) && $_GET['i'] != ''){
                $sid = $_GET['i'];
                $entity = Express::getObjectByHandle('goodsample');
                $list = new \Concrete\Core\Express\EntryList($entity);
                $list->filterBySid($sid);
                $result = $list->getResults();

                if (count($result) > 0){
                    foreach ($result as $shohindata){
                        $sname = $shohindata->getSname();
                        $sprice = $shohindata->getSprice();
                    }
                    $this->set('sid', $sid);
                    $this->set('sname', $sname);
                    $this->set('sprice', $sprice);
                    $this->set('section', 'edit');
                    $this->set('isvalid', true);
                    $this->set('title', '商品編集');
                }
                  
            }
        }

         private function validate(){
        //最初はバリデーション結果を成功に設定
            $isvalid = true;
            //ここから下に、データ入力状態の検証コードを記述
            //エラーを定義するときは $isvalid = false; とします。          

            //Viewに値を渡す
            $this->set('isvalid', $isvalid);           
            return $isvalid;
        }
        
        public function action_confirm(){
            $validate = $this->app->make('token')->validate('confirm_form');
              if ($validate != true){                
                throw new Exception(t("Invalid Token. Please contact webmaster."));                  
              }            
            $sid = $this->post('sid');
            $entity = Express::getObjectByHandle('goodsample');
            $list = new \Concrete\Core\Express\EntryList($entity);
            $list->filterBySid($sid);
            $result = $list->getResults();

            if (count($result) > 0){
                foreach ($result as $updatedata){
                    //エントリーIDを取得
                    $entid = $updatedata->getId();
                    $savedata = Express::getEntry($entid);
                    $savedata->setSid($this->post('sid'));
                    $savedata->setSname($this->post('sname'));
                    $savedata->setSprice($this->post('sprice'));
                    $savedata = Express::refresh($savedata);
                    $this->set('response', 'データの更新が終了しました。');
                }
                return true;
            }


        }
                 
    }
    
?>