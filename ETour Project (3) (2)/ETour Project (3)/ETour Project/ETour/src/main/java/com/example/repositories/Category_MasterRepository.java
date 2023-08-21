package com.example.repositories;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entity.Booking_Header;
import com.example.entity.Category_Master;

import jakarta.transaction.Transactional;


@Repository
@Transactional
public interface Category_MasterRepository extends JpaRepository<Category_Master, Integer> {

}
