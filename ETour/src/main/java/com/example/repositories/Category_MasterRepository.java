package com.example.repositories;
import java.util.Optional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.entity.Booking_Header;
import com.example.entity.Category_Master;

import jakarta.transaction.Transactional;
import java.util.List;



@Repository
@Transactional
public interface Category_MasterRepository extends JpaRepository<Category_Master, Integer> {
//@Modifying
//	@Query("UPDATE Category_Master c SET c.cat_name = :cat_name, c.catimagepath = :catimagepath, c.subcat_id = :subcat_id, c.cat_id = :cat_id WHERE c.catmaster_id = :catmaster_id")
//	  public void update(@Param("cat_name") String name, @Param("catimagepath") String imagePath, @Param("subcat_id") String subcategoryId, @Param("cat_id") String categoryId, @Param("catmaster_id") int id);

    

   public List<Category_Master> findBycatId(String catId);
    
    //List<Category_Master> findBycat_id(Object cat_id);
}

